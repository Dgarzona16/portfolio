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
    public partial class frmViewColeccion : Form
    {
        DataTable dt = new DataTable();
        public frmViewColeccion(DataTable coleccion)
        {
            InitializeComponent();
            dt = coleccion;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmViewColeccion_Load(object sender, EventArgs e)
        {
            lblNombre.Text = dt.Rows[0]["Nombre"].ToString();
            lblTipo.Text = dt.Rows[0]["Tipo"].ToString();
            lblGenero.Text = dt.Rows[0]["Genero"].ToString();
            lblArea.Text = dt.Rows[0]["Area"].ToString();
            lblPiso.Text = dt.Rows[0]["Piso"].ToString();
        }
    }
}
