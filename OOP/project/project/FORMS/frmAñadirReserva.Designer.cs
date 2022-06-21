namespace project.FORMS
{
    partial class frmAñadirReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdMaterial = new Krypton.Toolkit.KryptonTextBox();
            this.lblIdMaterial = new Krypton.Toolkit.KryptonLabel();
            this.txtIdUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.lblIdUsuario = new Krypton.Toolkit.KryptonLabel();
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.dtpHoraPrestamo = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaHoraPrestamo = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaPrestamo = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpHoraDevolucion = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaHoraDevolucion = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaDevolucion = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpHoraReserva = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaReserva = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaReserva = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // txtIdMaterial
            // 
            this.txtIdMaterial.Location = new System.Drawing.Point(81, 131);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.Size = new System.Drawing.Size(206, 27);
            this.txtIdMaterial.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdMaterial.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdMaterial.StateActive.Content.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdMaterial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdMaterial.StateCommon.Content.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.TabIndex = 6;
            this.txtIdMaterial.Text = "Id del Material";
            // 
            // lblIdMaterial
            // 
            this.lblIdMaterial.Location = new System.Drawing.Point(81, 100);
            this.lblIdMaterial.Name = "lblIdMaterial";
            this.lblIdMaterial.Size = new System.Drawing.Size(160, 25);
            this.lblIdMaterial.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.TabIndex = 5;
            this.lblIdMaterial.Values.Text = "Id del Material";
            this.lblIdMaterial.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(91, 268);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(206, 27);
            this.txtIdUsuario.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdUsuario.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdUsuario.StateActive.Content.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdUsuario.StateCommon.Content.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.TabIndex = 8;
            this.txtIdUsuario.Text = "Id del Usuario";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Location = new System.Drawing.Point(91, 237);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(150, 25);
            this.lblIdUsuario.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.TabIndex = 7;
            this.lblIdUsuario.Values.Text = "Id del Usuario";
            this.lblIdUsuario.Visible = false;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(313, 457);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(341, 31);
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 22;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(660, 451);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 37);
            this.btnAgregar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregar.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Values.Text = "Agregar Prestamo";
            // 
            // dtpHoraPrestamo
            // 
            this.dtpHoraPrestamo.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraPrestamo.Location = new System.Drawing.Point(563, 194);
            this.dtpHoraPrestamo.Name = "dtpHoraPrestamo";
            this.dtpHoraPrestamo.ShowUpDown = true;
            this.dtpHoraPrestamo.Size = new System.Drawing.Size(82, 22);
            this.dtpHoraPrestamo.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraPrestamo.TabIndex = 25;
            this.dtpHoraPrestamo.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHoraPrestamo
            // 
            this.lblFechaHoraPrestamo.Location = new System.Drawing.Point(425, 152);
            this.lblFechaHoraPrestamo.Name = "lblFechaHoraPrestamo";
            this.lblFechaHoraPrestamo.Size = new System.Drawing.Size(249, 25);
            this.lblFechaHoraPrestamo.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraPrestamo.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraPrestamo.TabIndex = 24;
            this.lblFechaHoraPrestamo.Values.Text = "Fecha y hora de Prestamo";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(425, 194);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(101, 22);
            this.dtpFechaPrestamo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaPrestamo.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrestamo.TabIndex = 23;
            this.dtpFechaPrestamo.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // dtpHoraDevolucion
            // 
            this.dtpHoraDevolucion.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraDevolucion.Location = new System.Drawing.Point(563, 320);
            this.dtpHoraDevolucion.Name = "dtpHoraDevolucion";
            this.dtpHoraDevolucion.ShowUpDown = true;
            this.dtpHoraDevolucion.Size = new System.Drawing.Size(82, 22);
            this.dtpHoraDevolucion.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraDevolucion.TabIndex = 28;
            this.dtpHoraDevolucion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHoraDevolucion
            // 
            this.lblFechaHoraDevolucion.Location = new System.Drawing.Point(425, 278);
            this.lblFechaHoraDevolucion.Name = "lblFechaHoraDevolucion";
            this.lblFechaHoraDevolucion.Size = new System.Drawing.Size(269, 25);
            this.lblFechaHoraDevolucion.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraDevolucion.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraDevolucion.TabIndex = 27;
            this.lblFechaHoraDevolucion.Values.Text = "Fecha y hora de Devolucion";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(425, 320);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(101, 22);
            this.dtpFechaDevolucion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaDevolucion.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevolucion.TabIndex = 26;
            this.dtpFechaDevolucion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(563, 86);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.ShowUpDown = true;
            this.dtpHoraReserva.Size = new System.Drawing.Size(82, 22);
            this.dtpHoraReserva.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.TabIndex = 31;
            this.dtpHoraReserva.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            this.dtpHoraReserva.Visible = false;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.Location = new System.Drawing.Point(425, 44);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(239, 25);
            this.lblFechaReserva.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.TabIndex = 30;
            this.lblFechaReserva.Values.Text = "Fecha y hora de Reserva";
            this.lblFechaReserva.Visible = false;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaReserva.Location = new System.Drawing.Point(425, 86);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(101, 22);
            this.dtpFechaReserva.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaReserva.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.TabIndex = 29;
            this.dtpFechaReserva.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            this.dtpFechaReserva.Visible = false;
            // 
            // frmAñadirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.dtpHoraReserva);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.dtpHoraDevolucion);
            this.Controls.Add(this.lblFechaHoraDevolucion);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.dtpHoraPrestamo);
            this.Controls.Add(this.lblFechaHoraPrestamo);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.txtIdMaterial);
            this.Controls.Add(this.lblIdMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAñadirReserva";
            this.Text = "frmAñadirReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtIdMaterial;
        private Krypton.Toolkit.KryptonLabel lblIdMaterial;
        private Krypton.Toolkit.KryptonTextBox txtIdUsuario;
        private Krypton.Toolkit.KryptonLabel lblIdUsuario;
        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHoraPrestamo;
        private Krypton.Toolkit.KryptonLabel lblFechaHoraPrestamo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaPrestamo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHoraDevolucion;
        private Krypton.Toolkit.KryptonLabel lblFechaHoraDevolucion;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaDevolucion;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHoraReserva;
        private Krypton.Toolkit.KryptonLabel lblFechaReserva;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaReserva;
    }
}