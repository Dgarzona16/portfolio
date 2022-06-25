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
using Zen.Barcode;

namespace project.FORMS
{
    public partial class frmViewCarnet : Form
    {
        DataTable dt = new DataTable();
        public frmViewCarnet(DataTable user)
        {
            InitializeComponent();
            dt = user;
        }
        private void frmViewCarnet_Load(object sender, EventArgs e)
        {
            //
            //Fotografia
            //
            picFotografia.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + dt.Rows[0]["Fotografia"].ToString());
            //
            //Ocupacion
            //
            lblOcupacion.Text = dt.Rows[0]["Ocupacion"].ToString();
            //
            //QR
            //
            CodeQrBarcodeDraw qrCodeImage = BarcodeDrawFactory.CodeQr;
            picQR.Image = qrCodeImage.Draw(dt.Rows[0]["Id"].ToString(), 5);
            //
            //Nombre
            //
            string Nombre = dt.Rows[0]["Nombre"].ToString();
            lblNombre.Text = Nombre;
            lblNombre.AutoSize = true;
            lblNombre.MaximumSize = new Size(100, 0);
            //
            //Telefono
            //
            lblTelefono.Text = dt.Rows[0]["Telefono"].ToString();
            //
            //Email
            //
            lblEmail.Text = dt.Rows[0]["Correo"].ToString();
            //
            //Id
            //
            lblId.Text = dt.Rows[0]["Id"].ToString();
        }
    }
}
