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
    public partial class frmAñadirMaterial : Form
    {
        MaterialSQL writer = new MaterialSQL();
        DataTable dtFormato;
        DataTable dtColeccion;
        private string target = "";
        private const string ruta = "ASSETS/IMG/MATERIAL/";
        public frmAñadirMaterial()
        {
            InitializeComponent();
            dtFormato = writer.getFormato();
            foreach (DataRow row in dtFormato.Rows)
            {
                cmbFormato.Items.Add(row[1].ToString());
            }
            dtColeccion = writer.getColecciones();
            foreach (DataRow row in dtColeccion.Rows)
            {
                cmbColeccion.Items.Add(row[1].ToString());
            }

        }
        //
        //Placeholder
        //
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre del Material")
            {
                txtNombre.Text = "";
                lblNombre.Visible = true;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre del Material";
                lblNombre.Visible = false;
            }
        }
        private void txtAutor_Enter(object sender, EventArgs e)
        {
            if (txtAutor.Text == "Nombre del Autor")
            {
                txtAutor.Text = "";
                lblAutor.Visible = true;
            }
        }
        private void txtAutor_Leave(object sender, EventArgs e)
        {
            if (txtAutor.Text == "")
            {
                txtAutor.Text = "Nombre del Autor";
                lblAutor.Visible = false;
            }
        }
        private void txtEditorial_Enter(object sender, EventArgs e)
        {
            if (txtEditorial.Text == "Nombre de Editorial")
            {
                txtEditorial.Text = "";
                lblEditorial.Visible = true;
            }
        }
        private void txtEditorial_Leave(object sender, EventArgs e)
        {
            if (txtEditorial.Text == "")
            {
                txtEditorial.Text = "Nombre de Editorial";
                lblEditorial.Visible = false;
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
        private void btnAgregarPortada_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
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
        //agregar palabras clave
        //
        private void btnAddPalabras_Click_1(object sender, EventArgs e)
        {
            cmbPalabras.Items.Add(cmbPalabras.Text);
            cmbPalabras.Text = "";
        }
        //
        //pasar etiquetas
        //
        private void passTag(int id)
        {
            if (chkISBN.Checked)
            {
                writer.InsertEtiqueta(id, chkISBN.Text);
                chkISBN.Checked = false;
            }
            if (chkISSN.Checked)
            {
                writer.InsertEtiqueta(id, chkISSN.Text);
                chkISSN.Checked = false;
            }
            if (chkDOI.Checked)
            {
                writer.InsertEtiqueta(id, chkDOI.Text);
                chkDOI.Checked = false;
            }
        }
        //
        //Enviar a DB
        //
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            NewMaterial @material = new NewMaterial();
            int idFormato = 0;
            int idColeccion = 0;
            for (int i = 0; i < dtFormato.Rows.Count; i++)
            {
                if (cmbFormato.Text == dtFormato.Rows[i][1].ToString())
                {
                    idFormato = Convert.ToInt32(dtFormato.Rows[i][0]);
                }
            }
            for (int i = 0; i < dtColeccion.Rows.Count; i++)
            {
                if (cmbColeccion.Text == dtColeccion.Rows[i][1].ToString())
                {
                    idColeccion = Convert.ToInt32(dtColeccion.Rows[i][0]);
                }
            }
            if (txtConfirmacion.Text == User_cache.Password)
            {
                if(target != "")
                {
                    File.Copy(target, AppDomain.CurrentDomain.BaseDirectory + ruta + Path.GetFileName(target));
                    @material.Portada = ruta + Path.GetFileName(target);
                }
                @material.Nombre = txtNombre.Text;
                @material.Autor = txtAutor.Text;
                @material.Editorial = txtEditorial.Text;
                @material.FechaPublicacion = dtpFechaPublicacion.Text;
                @material.Idioma = cmbIdiomas.Text;
                @material.Id_Formato = idFormato;
                @material.Id_Coleccion = idColeccion;

                if (writer.Insert(@material))
                {
                    MessageBox.Show($"{User_cache.Username} a agregado {txtNombre.Text} correctamente");
                    var id = writer.getId(@material);
                    passTag(id);
                    foreach (string palabra in cmbPalabras.Items)
                    {
                        writer.InsertPalabra(id, palabra);
                    }
                    txtNombre.Clear();
                    txtAutor.Clear();
                    txtEditorial.Clear();
                    txtConfirmacion.Clear();
                    cmbPalabras.Items.Clear();
                    picPortada.Image = null;
                }
                else
                {
                    MessageBox.Show("Error al agregar el material");
                }
            }
        }
    }
}
