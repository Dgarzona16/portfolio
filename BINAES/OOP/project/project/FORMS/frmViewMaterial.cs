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
    public partial class frmViewMaterial : Form
    {
        DataTable dt = new DataTable();
        public frmViewMaterial(DataTable material)
        {
            InitializeComponent();
            dt = material;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmViewMaterial_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = dt.Rows[0]["Nombre"].ToString();
            lblAutor.Text = dt.Rows[0]["Autor"].ToString();
            lblEditorial.Text = dt.Rows[0]["Editorial"].ToString();
            lblFormato.Text = dt.Rows[0]["Formato"].ToString();
            lblFechaPublicacion.Text = dt.Rows[0]["Fecha_Publicacion"].ToString();
            lblColeccion.Text = dt.Rows[0]["Coleccion"].ToString();
            lblIdioma.Text = dt.Rows[0]["Idioma"].ToString();
            try
            {
                picMaterial.Image = Image.FromFile(dt.Rows[0]["Portada"].ToString());
            }
            catch (Exception)
            {
                
            }
        }
    }
}