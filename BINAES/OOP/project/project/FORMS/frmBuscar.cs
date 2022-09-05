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
using Microsoft.VisualBasic;

namespace project.FORMS
{
    public partial class frmBuscar : Form
    {
        private FormTemplate constructor;
        private SQLReaderWriter reader;
        private ReserveSQL ReserveCase = new ReserveSQL();
        private int ID;
        public frmBuscar(FormTemplate completer)
        {
            InitializeComponent();
            completer.CmbItems.ForEach(x => cmbCatalogo.Items.Add(x));
            cmbCatalogo.Text = cmbCatalogo.Items[0].ToString();
            constructor = completer;
            reader = completer.consulta;
        }
        //
        //Busqueda en tiempo real
        //
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            dtgvResultado.DataSource = reader.consult(txtBuscador.Text, cmbCatalogo.Text);
        }
        //
        //Cargar contenido inicial
        //
        private void frmBuscar_Load(object sender, EventArgs e)
        {
            dtgvResultado.DataSource = reader.consult(txtBuscador.Text, cmbCatalogo.Text);
        }
        //
        //Mostrar Informacion mas completa
        //
        private void dtgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dtgvResultado_CellClick(sender, e);
            dt = reader.GetData(ID);
            constructor.RunView(dt);
        }
        //
        //Setear el Id 
        //
        private void dtgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dtgvResultado.Rows[rowIndex];
            ID = int.Parse(row.Cells["Id"].Value.ToString());
        }
        //
        //Eliminar de DB
        //
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var Validar = new frmDialogo())
            {
                Validar.ShowDialog();
                if (Validar.DialogResult == DialogResult.OK)
                {
                    if (cmbCatalogo.Text == "Reserva / Usuario")
                    {
                        if (ReserveCase.DeleteR(ID))
                        {
                            MessageBox.Show("Eliminado");
                        }
                        else
                        {
                            MessageBox.Show("Verifique que no existan datos dependiendo del que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (reader.Delete(ID))
                        {
                            MessageBox.Show("Eliminado");
                        }
                        else
                        {
                            MessageBox.Show("Verifique que no existan datos dependiendo del que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    dtgvResultado.DataSource = reader.consult(txtBuscador.Text, cmbCatalogo.Text);
                }
                else
                {
                    MessageBox.Show("Error al ingresar su contraseña");
                }
            }
        }
    }
}
