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
    public partial class frmAñadirEvento : Form
    {
        public frmAñadirEvento()
        {
            InitializeComponent();
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

    }
}
