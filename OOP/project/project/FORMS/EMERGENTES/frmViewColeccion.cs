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
        public frmViewColeccion(DataTable collection)
        {
            InitializeComponent();
            dt = collection;
        }
    }
}
