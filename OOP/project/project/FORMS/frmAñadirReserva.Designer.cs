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
            this.txtIdMaterial.Location = new System.Drawing.Point(81, 131);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.Size = new System.Drawing.Size(206, 22);
            this.txtIdMaterial.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtIdMaterial.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdMaterial.StateActive.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtIdMaterial.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtIdMaterial.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdMaterial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdMaterial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdMaterial.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtIdMaterial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaterial.TabIndex = 6;
            this.txtIdMaterial.Text = "Id del Material";
            this.txtIdMaterial.Enter += new System.EventHandler(this.txtIdMaterial_Enter);
            this.txtIdMaterial.Leave += new System.EventHandler(this.txtIdMaterial_Leave);
            // 
            // lblIdMaterial
            // 
            this.lblIdMaterial.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblIdMaterial.Location = new System.Drawing.Point(81, 100);
            this.lblIdMaterial.Name = "lblIdMaterial";
            this.lblIdMaterial.Size = new System.Drawing.Size(119, 23);
            this.lblIdMaterial.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblIdMaterial.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblIdMaterial.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaterial.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblIdMaterial.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblIdMaterial.TabIndex = 5;
            this.lblIdMaterial.Values.Text = "Id del Material";
            this.lblIdMaterial.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(91, 268);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(206, 22);
            this.txtIdUsuario.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtIdUsuario.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdUsuario.StateActive.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtIdUsuario.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtIdUsuario.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtIdUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtIdUsuario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtIdUsuario.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtIdUsuario.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.TabIndex = 8;
            this.txtIdUsuario.Text = "Id del Usuario";
            this.txtIdUsuario.Enter += new System.EventHandler(this.txtIdUsuario_Enter);
            this.txtIdUsuario.Leave += new System.EventHandler(this.txtIdUsuario_Leave);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblIdUsuario.Location = new System.Drawing.Point(91, 237);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(117, 23);
            this.lblIdUsuario.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblIdUsuario.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblIdUsuario.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblIdUsuario.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblIdUsuario.TabIndex = 7;
            this.lblIdUsuario.Values.Text = "Id del Usuario";
            this.lblIdUsuario.Visible = false;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(313, 457);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(341, 26);
            this.txtConfirmacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtConfirmacion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 22;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
            // 
            // dtpHoraPrestamo
            // 
            this.dtpHoraPrestamo.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHoraPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraPrestamo.Location = new System.Drawing.Point(563, 194);
            this.dtpHoraPrestamo.Name = "dtpHoraPrestamo";
            this.dtpHoraPrestamo.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpHoraPrestamo.ShowUpDown = true;
            this.dtpHoraPrestamo.Size = new System.Drawing.Size(82, 18);
            this.dtpHoraPrestamo.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHoraPrestamo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraPrestamo.TabIndex = 25;
            this.dtpHoraPrestamo.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHoraPrestamo
            // 
            this.lblFechaHoraPrestamo.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblFechaHoraPrestamo.Location = new System.Drawing.Point(425, 152);
            this.lblFechaHoraPrestamo.Name = "lblFechaHoraPrestamo";
            this.lblFechaHoraPrestamo.Size = new System.Drawing.Size(212, 23);
            this.lblFechaHoraPrestamo.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraPrestamo.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblFechaHoraPrestamo.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblFechaHoraPrestamo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraPrestamo.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblFechaHoraPrestamo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblFechaHoraPrestamo.TabIndex = 24;
            this.lblFechaHoraPrestamo.Values.Text = "Fecha y hora de Prestamo";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(425, 194);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(101, 18);
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
            this.dtpHoraDevolucion.Location = new System.Drawing.Point(563, 320);
            this.dtpHoraDevolucion.Name = "dtpHoraDevolucion";
            this.dtpHoraDevolucion.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpHoraDevolucion.ShowUpDown = true;
            this.dtpHoraDevolucion.Size = new System.Drawing.Size(82, 18);
            this.dtpHoraDevolucion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHoraDevolucion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraDevolucion.TabIndex = 28;
            this.dtpHoraDevolucion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHoraDevolucion
            // 
            this.lblFechaHoraDevolucion.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblFechaHoraDevolucion.Location = new System.Drawing.Point(425, 278);
            this.lblFechaHoraDevolucion.Name = "lblFechaHoraDevolucion";
            this.lblFechaHoraDevolucion.Size = new System.Drawing.Size(224, 23);
            this.lblFechaHoraDevolucion.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraDevolucion.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblFechaHoraDevolucion.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblFechaHoraDevolucion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraDevolucion.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblFechaHoraDevolucion.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblFechaHoraDevolucion.TabIndex = 27;
            this.lblFechaHoraDevolucion.Values.Text = "Fecha y hora de Devolucion";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(425, 320);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(101, 18);
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
            this.dtpHoraReserva.Location = new System.Drawing.Point(563, 86);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpHoraReserva.ShowUpDown = true;
            this.dtpHoraReserva.Size = new System.Drawing.Size(82, 18);
            this.dtpHoraReserva.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHoraReserva.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.TabIndex = 31;
            this.dtpHoraReserva.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            this.dtpHoraReserva.Visible = false;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblFechaReserva.Location = new System.Drawing.Point(425, 44);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(202, 23);
            this.lblFechaReserva.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.StateCommon.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblFechaReserva.StateCommon.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.lblFechaReserva.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.lblFechaReserva.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
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
            this.dtpFechaReserva.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpFechaReserva.Size = new System.Drawing.Size(101, 18);
            this.dtpFechaReserva.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFechaReserva.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaReserva.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.TabIndex = 29;
            this.dtpFechaReserva.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            this.dtpFechaReserva.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(660, 451);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 37);
            this.btnAgregar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnAgregar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregar.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StatePressed.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregar.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregar.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Values.Text = "Agregar Prestamo";
            // 
            // frmAñadirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
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