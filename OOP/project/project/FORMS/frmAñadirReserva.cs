using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.FORMS
{
    public partial class frmAñadirReserva : Form
    {
        public frmAñadirReserva()
        {
            InitializeComponent();
        }
        //
        //Placeholder
        //
        private void txtIdMaterial_Enter(object sender, EventArgs e)
        {
            if (txtIdMaterial.Text == "Id del Material")
            {
                txtIdMaterial.Text = "";
                lblIdMaterial.Visible = true;
            }
        }
        private void txtIdMaterial_Leave(object sender, EventArgs e)
        {
            if (txtIdMaterial.Text == "")
            {
                txtIdMaterial.Text = "Id del Material";
                lblIdMaterial.Visible = false;
            }
        }
        private void txtIdUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "Id del Usuario")
            {
                txtIdUsuario.Text = "";
                lblIdUsuario.Visible = true;
            }
        }
        private void txtIdUsuario_Leave(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
            {
                txtIdUsuario.Text = "Id del Usuario";
                lblIdUsuario.Visible = false;
            }
        }
    }
}
