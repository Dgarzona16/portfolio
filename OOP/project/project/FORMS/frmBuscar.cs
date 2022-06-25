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
    public partial class frmBuscar : Form
    {
        private FormTemplate consultor;
        private SQLReaderWriter reader;
        public frmBuscar(FormTemplate completer)
        {
            InitializeComponent();
            completer.CmbItems.ForEach(x => cmbCatalogo.Items.Add(x));
            cmbCatalogo.Text = cmbCatalogo.Items[0].ToString();
            consultor = completer;
            reader = completer.consulta;
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            dtgvResultado.DataSource = consultor.consulta.consult(txtBuscador.Text, cmbCatalogo.Text);
        }
        private void frmBuscar_Load(object sender, EventArgs e)
        {
            dtgvResultado.DataSource = consultor.consulta.consult(txtBuscador.Text, cmbCatalogo.Text);
        }
        private void dtgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dtgvResultado.Rows[rowIndex];
            dt = reader.GetData(Convert.ToInt32(row.Cells["id"].Value.ToString()));

            consultor.RunView(dt);
        }
    }
}
