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
            this.dtpHoraPrestamo = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaHoraPrestamo = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaPrestamo = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpHoraDevolucion = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaHoraDevolucion = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaDevolucion = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpHoraReserva = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaReserva = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaReserva = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txtIdMaterial
            // 
            this.txtIdMaterial.Location = new System.Drawing.Point(108, 161);
            this.txtIdMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.Size = new System.Drawing.Size(275, 26);
            this.txtIdMaterial.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtIdMaterial.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdMaterial.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtIdMaterial.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdMaterial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdMaterial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.TabIndex = 6;
            this.txtIdMaterial.Text = "Id del Material";
            this.txtIdMaterial.Enter += new System.EventHandler(this.txtIdMaterial_Enter);
            this.txtIdMaterial.Leave += new System.EventHandler(this.txtIdMaterial_Leave);
            // 
            // lblIdMaterial
            // 
            this.lblIdMaterial.Location = new System.Drawing.Point(108, 123);
            this.lblIdMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdMaterial.Name = "lblIdMaterial";
            this.lblIdMaterial.Size = new System.Drawing.Size(148, 28);
            this.lblIdMaterial.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.TabIndex = 5;
            this.lblIdMaterial.Values.Text = "Id del Material";
            this.lblIdMaterial.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(121, 330);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(275, 26);
            this.txtIdUsuario.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtIdUsuario.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdUsuario.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtIdUsuario.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdUsuario.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.TabIndex = 8;
            this.txtIdUsuario.Text = "Id del Usuario";
            this.txtIdUsuario.Enter += new System.EventHandler(this.txtIdUsuario_Enter);
            this.txtIdUsuario.Leave += new System.EventHandler(this.txtIdUsuario_Leave);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Location = new System.Drawing.Point(121, 292);
            this.lblIdUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(145, 28);
            this.lblIdUsuario.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.TabIndex = 7;
            this.lblIdUsuario.Values.Text = "Id del Usuario";
            this.lblIdUsuario.Visible = false;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(417, 562);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(455, 31);
            this.txtConfirmacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtConfirmacion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 22;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            // 
            // dtpHoraPrestamo
            // 
            this.dtpHoraPrestamo.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraPrestamo.Location = new System.Drawing.Point(751, 239);
            this.dtpHoraPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraPrestamo.Name = "dtpHoraPrestamo";
            this.dtpHoraPrestamo.ShowUpDown = true;
            this.dtpHoraPrestamo.Size = new System.Drawing.Size(109, 22);
            this.dtpHoraPrestamo.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHoraPrestamo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraPrestamo.TabIndex = 25;
            this.dtpHoraPrestamo.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHoraPrestamo
            // 
            this.lblFechaHoraPrestamo.Location = new System.Drawing.Point(567, 187);
            this.lblFechaHoraPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaHoraPrestamo.Name = "lblFechaHoraPrestamo";
            this.lblFechaHoraPrestamo.Size = new System.Drawing.Size(263, 28);
            this.lblFechaHoraPrestamo.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraPrestamo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraPrestamo.TabIndex = 24;
            this.lblFechaHoraPrestamo.Values.Text = "Fecha y hora de Prestamo";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(567, 239);
            this.dtpFechaPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(135, 22);
            this.dtpFechaPrestamo.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFechaPrestamo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaPrestamo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrestamo.TabIndex = 23;
            this.dtpFechaPrestamo.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // dtpHoraDevolucion
            // 
            this.dtpHoraDevolucion.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraDevolucion.Location = new System.Drawing.Point(751, 394);
            this.dtpHoraDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraDevolucion.Name = "dtpHoraDevolucion";
            this.dtpHoraDevolucion.ShowUpDown = true;
            this.dtpHoraDevolucion.Size = new System.Drawing.Size(109, 22);
            this.dtpHoraDevolucion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHoraDevolucion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraDevolucion.TabIndex = 28;
            this.dtpHoraDevolucion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHoraDevolucion
            // 
            this.lblFechaHoraDevolucion.Location = new System.Drawing.Point(567, 342);
            this.lblFechaHoraDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaHoraDevolucion.Name = "lblFechaHoraDevolucion";
            this.lblFechaHoraDevolucion.Size = new System.Drawing.Size(278, 28);
            this.lblFechaHoraDevolucion.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraDevolucion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraDevolucion.TabIndex = 27;
            this.lblFechaHoraDevolucion.Values.Text = "Fecha y hora de Devolucion";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(567, 394);
            this.dtpFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(135, 22);
            this.dtpFechaDevolucion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFechaDevolucion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaDevolucion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevolucion.TabIndex = 26;
            this.dtpFechaDevolucion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(751, 106);
            this.dtpHoraReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.ShowUpDown = true;
            this.dtpHoraReserva.Size = new System.Drawing.Size(109, 22);
            this.dtpHoraReserva.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHoraReserva.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.TabIndex = 31;
            this.dtpHoraReserva.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            this.dtpHoraReserva.Visible = false;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.Location = new System.Drawing.Point(567, 54);
            this.lblFechaReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(251, 28);
            this.lblFechaReserva.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.TabIndex = 30;
            this.lblFechaReserva.Values.Text = "Fecha y hora de Reserva";
            this.lblFechaReserva.Visible = false;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaReserva.Location = new System.Drawing.Point(567, 106);
            this.dtpFechaReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(135, 22);
            this.dtpFechaReserva.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFechaReserva.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaReserva.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.TabIndex = 29;
            this.dtpFechaReserva.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            this.dtpFechaReserva.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(880, 555);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(216, 46);
            this.btnAgregar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregar.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Values.Text = "Agregar Prestamo";
            // 
            // frmAñadirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(1124, 615);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Krypton.Toolkit.KryptonDateTimePicker dtpHoraPrestamo;
        private Krypton.Toolkit.KryptonLabel lblFechaHoraPrestamo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaPrestamo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHoraDevolucion;
        private Krypton.Toolkit.KryptonLabel lblFechaHoraDevolucion;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaDevolucion;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHoraReserva;
        private Krypton.Toolkit.KryptonLabel lblFechaReserva;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaReserva;
        private Krypton.Toolkit.KryptonButton btnAgregar;
    }
}