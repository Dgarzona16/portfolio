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
    public partial class frmAñadirUsuario : Form
    {
        UserSQL writer = new UserSQL();
        private string target = "";
        private const string ruta = "ASSETS/IMG/USER/";
        public frmAñadirUsuario()
        {
            InitializeComponent();
        }
        //
        //Placeholder
        //
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre del Usuario")
            {
                txtNombre.Text = "";
                lblNombre.Visible = true;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre del Usuario";
                lblNombre.Visible = false;
            }
        }
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
                lblDireccion.Visible = true;
            }
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Direccion";
                lblDireccion.Visible = false;
            }
        }
        private void txtInstitucion_Enter(object sender, EventArgs e)
        {
            if (txtInstitucion.Text == "Institucion")
            {
                txtInstitucion.Text = "";
                lblInstitucion.Visible = true;
            }
        }
        private void txtInstitucion_Leave(object sender, EventArgs e)
        {
            if (txtInstitucion.Text == "")
            {
                txtInstitucion.Text = "Institucion";
                lblInstitucion.Visible = false;
            }
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                lblTelefono.Visible = true;
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                lblTelefono.Visible = false;
            }
        }
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electronico")
            {
                txtCorreo.Text = "";
                lblCorreo.Visible = true;
            }
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo electronico";
                lblCorreo.Visible = false;
            }
        }
        private void txtOcupacion_Enter(object sender, EventArgs e)
        {
            if (txtOcupacion.Text == "Ocupacion")
            {
                txtOcupacion.Text = "";
                lblOcupacion.Visible = true;
            }
        }
        private void txtOcupacion_Leave(object sender, EventArgs e)
        {
            if (txtOcupacion.Text == "")
            {
                txtOcupacion.Text = "Ocupacion";
                lblOcupacion.Visible = false;
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
        private void btnAgregarFotografia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picFotografia.Image = Image.FromFile(openFileDialog.FileName);
                    target = openFileDialog.FileName;
                }
            }
        }
        //
        //Enviar a DB
        //
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NewUser @user = new NewUser();
            
            if (txtConfirmacion.Text == User_cache.Password)
            {
                if (target != "") 
                {
                    File.Copy(target, AppDomain.CurrentDomain.BaseDirectory + ruta + Path.GetFileName(target));
                    @user.Fotografia = ruta + Path.GetFileName(target);
                }
                @user.Nombre = txtNombre.Text;
                @user.Direccion = txtDireccion.Text;
                @user.Institucion = txtInstitucion.Text;
                @user.Telefono = txtTelefono.Text;
                @user.Correo = txtCorreo.Text;
                @user.Ocupacion = txtOcupacion.Text;

                if (writer.Insert(@user))
                {
                    MessageBox.Show($"{User_cache.Username} a agregado un usuario correctamente");
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtInstitucion.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtOcupacion.Clear();
                    txtConfirmacion.Clear();
                    picFotografia.Image = null;
                }
                else
                {
                    MessageBox.Show("Error al agregar usuario");
                }
            }
        }
    }
}
