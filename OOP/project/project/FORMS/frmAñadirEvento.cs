using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using project.CLASS;
using project.CONNECT_SQL;

namespace project.FORMS
{
    public partial class frmAñadirEvento : Form
    {
        private EventSQL writer;
        private string target ="";
        DataTable dt;
        int cont = 0;
        public frmAñadirEvento()
        {
            InitializeComponent();
            writer = new EventSQL();
            dt = writer.getAreas();
            foreach (DataRow row in dt.Rows)
            {
                cmbAreas.Items.Add(row[1].ToString());
                cont++;
            }
        }
        //
        //placeholder
        //
        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Titulo del Evento")
            {
                txtTitulo.Text = "";
                lblTitulo.Visible = true;
            }
        }
        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Titulo del Evento";
                lblTitulo.Visible = false;
            }
        }
        private void txtConfirmacion_Enter(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "Confirmar contraseña")
            {
                txtConfirmacion.Text = "";
                txtConfirmacion.StateCommon.Content.Color1 = Color.Black;
                txtConfirmacion.UseSystemPasswordChar = true;
            }
        }
        private void txtConfirmacion_Leave(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "")
            {
                txtConfirmacion.Text = "Confirmar contraseña";
                txtConfirmacion.StateCommon.Content.Color1 = Color.Gray;
                txtConfirmacion.UseSystemPasswordChar = false;
            }
        }
        //
        //Agregar foto
        //
        private void btnAgregarPortada_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picPortada.Image = Image.FromFile(openFileDialog.FileName);
                    target = openFileDialog.FileName;
                }
            }
        }
        //
        //Agregar objetivos 
        //
        private void btnAddObjetivos_Click(object sender, EventArgs e)
        {
            cmbObjetivos.Items.Add(cmbObjetivos.Text);
        }
        //
        //Enviar a BD
        //
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NewEvent @event = new NewEvent();
            int area = 0;
            string ruta = "ASSETS/IMG/EVENT/";
            for (var i = 0; i < cont; i++)
            {
                if (cmbAreas.Text == dt.Rows[i][1].ToString())
                {
                    area = Convert.ToInt32(dt.Rows[i][0]);
                }
            }
            if (txtConfirmacion.Text == User_cache.Password)
            {
                if(target != "")
                {
                    File.Copy(target, AppDomain.CurrentDomain.BaseDirectory + ruta + Path.GetFileName(target));
                    @event.Imagen = ruta + Path.GetFileName(target);
                }

                @event.Titulo = txtTitulo.Text;
                @event.Id_Area = area;
                @event.FechaHora_Inicio = dtpFecha_Init.Text + " " + dtpHora_init.Text;
                @event.FechaHora_Fin = dtpFecha_Fin.Text + " " + dtpHora_fin.Text;
                @event.CantidadParticipantes = Convert.ToInt32(nudCantParticipantes.Value);
                


                if (writer.Insert(@event))
                {
                    int id = writer.getId(@event);
                    foreach (string objetivo in cmbObjetivos.Items)
                    {
                        writer.InsertObjetivo(id, objetivo);
                    }
                    MessageBox.Show($"{User_cache.Username} ha agregado el evento {@event.Titulo} correctamente");
                    txtTitulo.Clear();
                    txtConfirmacion.Clear();
                    nudCantParticipantes.Value = 0;
                    picPortada.Image = null;
                    
                }
                else
                {
                    MessageBox.Show("Error al agregar el evento");
                }
            }
        }
    }
}
