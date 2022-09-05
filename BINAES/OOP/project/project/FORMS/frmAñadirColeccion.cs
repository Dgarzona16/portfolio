using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.CLASS;
using project.CONNECT_SQL;

namespace project.FORMS
{
    public partial class frmAñadirColeccion : Form
    {
        CollectionSQL writer;
        DataTable dt;
        int cont = 0;
        public frmAñadirColeccion()
        {
            InitializeComponent();
            writer = new CollectionSQL();
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
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre de colección")
            {
                txtNombre.Text = "";
                lblNombre.Visible = true;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre de colección";
                lblNombre.Visible = false;
            }
        }
        private void txtTipo_Enter(object sender, EventArgs e)
        {
            if (txtTipo.Text == "Tipo de colección")
            {
                txtTipo.Text = "";
                lblTipo.Visible = true;
            }
        }
        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                txtTipo.Text = "Tipo de colección";
                lblTipo.Visible = false;
            }
        }
        private void txtGenero_Enter(object sender, EventArgs e)
        {
            if (txtGenero.Text == "Género de colección")
            {
                txtGenero.Text = "";
                lblGenero.Visible = true;
            }
        }
        private void txtGenero_Leave(object sender, EventArgs e)
        {
            if (txtGenero.Text == "")
            {
                txtGenero.Text = "Género de colección";
                lblGenero.Visible = false;
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
        //Enviar a DB
        //
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NewCollection @collection = new NewCollection();
            int area = 1;
            for (var i = 0; i < cont; i++)
            {
                if (cmbAreas.Text == dt.Rows[i][1].ToString())
                {
                    area = Convert.ToInt32(dt.Rows[i][0]);
                }
            }
            if (txtConfirmacion.Text == User_cache.Password)
            {
                @collection.Nombre = txtNombre.Text;
                @collection.Tipo = txtTipo.Text;
                @collection.Genero = txtGenero.Text;
                @collection.Id_Area = area;

                if (writer.Insert(@collection))
                {
                    MessageBox.Show($"La colección {collection.Nombre} a sido agregada correctamente por {User_cache.Username}");
                    txtNombre.Clear();
                    txtTipo.Clear();
                    txtGenero.Clear();
                    txtConfirmacion.Clear();
                    cmbAreas.Text = "";
                }
                else
                {
                    MessageBox.Show("¡Error al agregar la colección!");
                }
            }
        }
    }
}