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
<<<<<<< HEAD
	public partial class frmAñadirReserva : Form
	{
		ReserveSQL writer = new ReserveSQL();
		bool prestamo = true;
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
		private void txtConfirmacion_Enter(object sender, EventArgs e)
		{
			if (txtConfirmacion.Text == "Confirmar contraseña")
			{
				txtConfirmacion.Text = "";
				txtConfirmacion.UseSystemPasswordChar = true;
				txtConfirmacion.StateCommon.Content.Color1 = Color.Black;
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
		//Verificar prestamo o reserva
		//
		private void btnValidar_Click(object sender, EventArgs e)
		{
			if (writer.validBorrow(Convert.ToInt32(txtIdMaterial.Text),dtpFechaPrestamo.Text + " " + dtpHoraPrestamo.Text, dtpFechaDevolucion.Text + " " + dtpHoraDevolucion.Text))
			{
				MessageBox.Show("El material se puede prestar");
			}
			else
			{
				MessageBox.Show("El material no se puede prestar");
				lblFechaReserva.Visible = true;
				dtpFechaReserva.Visible = true;
				dtpHoraReserva.Visible = true;
				dtpFechaReserva.Value = DateTime.Now;
				dtpHoraReserva.Value = DateTime.Now;
				dtpFechaReserva.Enabled = false;
				dtpHoraReserva.Enabled = false;
				prestamo = false;
			}
		}
		//
		//agregar a DB
		//
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			NewReservation @reserve = new NewReservation();
			if (txtConfirmacion.Text == User_cache.Password)
			{
				@reserve.Id_Material = Convert.ToInt32(txtIdMaterial.Text);
				@reserve.Id_Usuario = Convert.ToInt32(txtIdUsuario.Text);
				@reserve.FechaHora_Prestamo = dtpFechaPrestamo.Text + " " + dtpHoraPrestamo.Text;
				@reserve.FechaHora_Devolucion = dtpFechaDevolucion.Text + " " + dtpHoraDevolucion.Text;
				@reserve.FechaHora_Reserva = dtpFechaReserva.Text + " " + dtpHoraReserva.Text;

				if (prestamo)
				{
					if (writer.InsertPrestamo(@reserve))
					{
						MessageBox.Show("Prestamo agregado");
					}
					else
					{
						MessageBox.Show("Error al agregar reserva");
					}
				}
				else
				{
					if (writer.InsertReserva(@reserve))
					{
						MessageBox.Show("Reserva agregada");
					}
					else
					{
						MessageBox.Show("Error al agregar reserva");
					}
				}
				txtConfirmacion.Clear();
				txtIdMaterial.Clear();
				txtIdUsuario.Clear();
				dtpFechaReserva.Visible = false;
				dtpHoraReserva.Visible = false;
			}
		}
	}
=======
    public partial class frmAñadirReserva : Form
    {
        ReserveSQL writer = new ReserveSQL();
        bool prestamo = true;
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
        private void txtConfirmacion_Enter(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "Confirmar contraseña")
            {
                txtConfirmacion.Text = "";
                txtConfirmacion.UseSystemPasswordChar = true;
                txtConfirmacion.StateCommon.Content.Color1 = Color.FromArgb(6,29,63);
            }
        }
        private void txtConfirmacion_Leave(object sender, EventArgs e)
        {
            if (txtConfirmacion.Text == "")
            {
                txtConfirmacion.Text = "Confirmar contraseña";
                txtConfirmacion.StateCommon.Content.Color1 = Color.FromArgb(6,29,63);
                txtConfirmacion.UseSystemPasswordChar = false;
            }
        }
        //
        //Verificar prestamo o reserva
        //
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (writer.validBorrow(Convert.ToInt32(txtIdMaterial.Text),dtpFechaPrestamo.Text + " " + dtpHoraPrestamo.Text, dtpFechaDevolucion.Text + " " + dtpHoraDevolucion.Text))
            {
                MessageBox.Show("El material se puede prestar");
            }
            else
            {
                MessageBox.Show("El material no se puede prestar");
                lblFechaReserva.Visible = true;
                dtpFechaReserva.Visible = true;
                dtpHoraReserva.Visible = true;
                dtpFechaReserva.Value = DateTime.Now;
                dtpHoraReserva.Value = DateTime.Now;
                dtpFechaReserva.Enabled = false;
                dtpHoraReserva.Enabled = false;
                prestamo = false;
            }
        }
        //
        //agregar a DB
        //
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NewReservation @reserve = new NewReservation();
            if (txtConfirmacion.Text == User_cache.Password)
            {
                @reserve.Id_Material = Convert.ToInt32(txtIdMaterial.Text);
                @reserve.Id_Usuario = Convert.ToInt32(txtIdUsuario.Text);
                @reserve.FechaHora_Prestamo = dtpFechaPrestamo.Text + " " + dtpHoraPrestamo.Text;
                @reserve.FechaHora_Devolucion = dtpFechaDevolucion.Text + " " + dtpHoraDevolucion.Text;
                @reserve.FechaHora_Reserva = dtpFechaReserva.Text + " " + dtpHoraReserva.Text;

                if (prestamo)
                {
                    if (writer.InsertPrestamo(@reserve))
                    {
                        MessageBox.Show("Prestamo agregado");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar reserva");
                    }
                }
                else
                {
                    if (writer.InsertReserva(@reserve))
                    {
                        MessageBox.Show("Reserva agregada");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar reserva");
                    }
                }
                txtConfirmacion.Clear();
                txtIdMaterial.Clear();
                txtIdUsuario.Clear();
                dtpFechaReserva.Visible = false;
                dtpHoraReserva.Visible = false;
            }
        }
        
    }
>>>>>>> abe0915cf6e5fb59ea1fb92b7427fbc686784587
}
