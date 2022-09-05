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
    public partial class frmViewEvento : Form
    {
        DataTable dt = new DataTable();
        public frmViewEvento(DataTable evento)
        {
            InitializeComponent();
            dt = evento;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmViewEvento_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = dt.Rows[0]["Titulo"].ToString();
            lblFeHoInicio.Text = dt.Rows[0]["FechaHora_Inicio"].ToString();
            lblFeHoFinal.Text = dt.Rows[0]["FechaHora_Fin"].ToString();
            lblArea.Text = dt.Rows[0]["Area"].ToString();
            lblPiso.Text = dt.Rows[0]["Piso"].ToString();
            lblParticipantes.Text = dt.Rows[0]["CantidadParticipantes"].ToString();
            try
            {
                picEvento.Image = Image.FromFile(dt.Rows[0]["Imagen"].ToString());
            }
            catch (Exception)
            {
            }
        }
    }
}
