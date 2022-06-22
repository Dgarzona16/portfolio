namespace project.FORMS
{
    partial class frmAñadirMaterial
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
            this.lblNombre = new Krypton.Toolkit.KryptonLabel();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.lblAutor = new Krypton.Toolkit.KryptonLabel();
            this.txtAutor = new Krypton.Toolkit.KryptonTextBox();
            this.cmbIdiomas = new Krypton.Toolkit.KryptonComboBox();
            this.lblIdioma = new Krypton.Toolkit.KryptonLabel();
            this.txtEditorial = new Krypton.Toolkit.KryptonTextBox();
            this.lblEditorial = new Krypton.Toolkit.KryptonLabel();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.btnAgregarPortada = new Krypton.Toolkit.KryptonButton();
            this.dtpFechaPublicacion = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFecha = new Krypton.Toolkit.KryptonLabel();
            this.lblFormato = new Krypton.Toolkit.KryptonLabel();
            this.lblColeccion = new Krypton.Toolkit.KryptonLabel();
            this.cmbFormato = new Krypton.Toolkit.KryptonComboBox();
            this.cmbColeccion = new Krypton.Toolkit.KryptonComboBox();
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.chkDOI = new Krypton.Toolkit.KryptonCheckBox();
            this.chkISSN = new Krypton.Toolkit.KryptonCheckBox();
            this.chkISBN = new Krypton.Toolkit.KryptonCheckBox();
            this.lblEtiqueta = new Krypton.Toolkit.KryptonLabel();
            this.cmbPalabras = new Krypton.Toolkit.KryptonComboBox();
            this.lblPalabras = new Krypton.Toolkit.KryptonLabel();
            this.btnAddPalabras = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPalabras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(12, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(200, 25);
            this.lblNombre.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Values.Text = "Nombre del Material";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 27);
            this.txtNombre.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtNombre.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNombre.StateActive.Content.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtNombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNombre.StateCommon.Content.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre del Material";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblAutor
            // 
            this.lblAutor.Location = new System.Drawing.Point(12, 107);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(170, 25);
            this.lblAutor.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Values.Text = "Nombre del Autor";
            this.lblAutor.Visible = false;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(12, 138);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(206, 27);
            this.txtAutor.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtAutor.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtAutor.StateActive.Content.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtAutor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtAutor.StateCommon.Content.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.TabIndex = 6;
            this.txtAutor.Text = "Nombre del Autor";
            this.txtAutor.Enter += new System.EventHandler(this.txtAutor_Enter);
            this.txtAutor.Leave += new System.EventHandler(this.txtAutor_Leave);
            // 
            // cmbIdiomas
            // 
            this.cmbIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomas.DropDownWidth = 170;
            this.cmbIdiomas.IntegralHeight = false;
            this.cmbIdiomas.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Frances",
            "Japones",
            "Italiano",
            "Mandarin"});
            this.cmbIdiomas.Location = new System.Drawing.Point(12, 308);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(170, 20);
            this.cmbIdiomas.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdiomas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbIdiomas.TabIndex = 7;
            // 
            // lblIdioma
            // 
            this.lblIdioma.Location = new System.Drawing.Point(12, 277);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(71, 25);
            this.lblIdioma.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.TabIndex = 8;
            this.lblIdioma.Values.Text = "Idioma";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(12, 221);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(206, 27);
            this.txtEditorial.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtEditorial.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtEditorial.StateActive.Content.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtEditorial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtEditorial.StateCommon.Content.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.TabIndex = 10;
            this.txtEditorial.Text = "Nombre de Editorial";
            this.txtEditorial.Enter += new System.EventHandler(this.txtEditorial_Enter);
            this.txtEditorial.Leave += new System.EventHandler(this.txtEditorial_Leave);
            // 
            // lblEditorial
            // 
            this.lblEditorial.Location = new System.Drawing.Point(12, 190);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(200, 25);
            this.lblEditorial.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.TabIndex = 9;
            this.lblEditorial.Values.Text = "Nombre de Editorial";
            this.lblEditorial.Visible = false;
            // 
            // picPortada
            // 
            this.picPortada.Location = new System.Drawing.Point(581, 23);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(207, 215);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 11;
            this.picPortada.TabStop = false;
            // 
            // btnAgregarPortada
            // 
            this.btnAgregarPortada.Location = new System.Drawing.Point(567, 253);
            this.btnAgregarPortada.Name = "btnAgregarPortada";
            this.btnAgregarPortada.Size = new System.Drawing.Size(233, 37);
            this.btnAgregarPortada.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPortada.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregarPortada.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregarPortada.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregarPortada.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAgregarPortada.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarPortada.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAgregarPortada.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAgregarPortada.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPortada.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregarPortada.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregarPortada.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregarPortada.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAgregarPortada.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregarPortada.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPortada.TabIndex = 12;
            this.btnAgregarPortada.Values.Text = "Agregar una Imagen";
            this.btnAgregarPortada.Click += new System.EventHandler(this.btnAgregarPortada_Click);
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(293, 59);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(101, 22);
            this.dtpFechaPublicacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaPublicacion.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPublicacion.TabIndex = 13;
            this.dtpFechaPublicacion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(293, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(210, 25);
            this.lblFecha.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Values.Text = "Fecha de Publicacion";
            // 
            // lblFormato
            // 
            this.lblFormato.Location = new System.Drawing.Point(12, 344);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(81, 25);
            this.lblFormato.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.TabIndex = 15;
            this.lblFormato.Values.Text = "Formato";
            // 
            // lblColeccion
            // 
            this.lblColeccion.Location = new System.Drawing.Point(293, 107);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(101, 25);
            this.lblColeccion.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.TabIndex = 16;
            this.lblColeccion.Values.Text = "Coleccion";
            // 
            // cmbFormato
            // 
            this.cmbFormato.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.DropDownWidth = 192;
            this.cmbFormato.IntegralHeight = false;
            this.cmbFormato.Location = new System.Drawing.Point(12, 376);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(170, 20);
            this.cmbFormato.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormato.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFormato.TabIndex = 17;
            // 
            // cmbColeccion
            // 
            this.cmbColeccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccion.DropDownWidth = 121;
            this.cmbColeccion.IntegralHeight = false;
            this.cmbColeccion.Location = new System.Drawing.Point(293, 138);
            this.cmbColeccion.Name = "cmbColeccion";
            this.cmbColeccion.Size = new System.Drawing.Size(192, 20);
            this.cmbColeccion.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColeccion.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbColeccion.TabIndex = 18;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(291, 451);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(341, 31);
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 20;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(638, 445);
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
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Values.Text = "Agregar Material";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkDOI
            // 
            this.chkDOI.Location = new System.Drawing.Point(293, 255);
            this.chkDOI.Name = "chkDOI";
            this.chkDOI.Size = new System.Drawing.Size(45, 20);
            this.chkDOI.TabIndex = 21;
            this.chkDOI.Values.Text = "DOI";
            // 
            // chkISSN
            // 
            this.chkISSN.Location = new System.Drawing.Point(293, 229);
            this.chkISSN.Name = "chkISSN";
            this.chkISSN.Size = new System.Drawing.Size(49, 20);
            this.chkISSN.TabIndex = 22;
            this.chkISSN.Values.Text = "ISSN";
            // 
            // chkISBN
            // 
            this.chkISBN.Location = new System.Drawing.Point(293, 203);
            this.chkISBN.Name = "chkISBN";
            this.chkISBN.Size = new System.Drawing.Size(50, 20);
            this.chkISBN.TabIndex = 23;
            this.chkISBN.Values.Text = "ISBN";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Location = new System.Drawing.Point(293, 172);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(101, 25);
            this.lblEtiqueta.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.TabIndex = 25;
            this.lblEtiqueta.Values.Text = "Etiquetas";
            // 
            // cmbPalabras
            // 
            this.cmbPalabras.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPalabras.DropDownWidth = 121;
            this.cmbPalabras.IntegralHeight = false;
            this.cmbPalabras.Location = new System.Drawing.Point(291, 334);
            this.cmbPalabras.Name = "cmbPalabras";
            this.cmbPalabras.Size = new System.Drawing.Size(192, 20);
            this.cmbPalabras.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPalabras.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbPalabras.TabIndex = 27;
            // 
            // lblPalabras
            // 
            this.lblPalabras.Location = new System.Drawing.Point(291, 303);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(150, 25);
            this.lblPalabras.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.TabIndex = 26;
            this.lblPalabras.Values.Text = "Palabras clave";
            // 
            // btnAddPalabras
            // 
            this.btnAddPalabras.Location = new System.Drawing.Point(291, 360);
            this.btnAddPalabras.Name = "btnAddPalabras";
            this.btnAddPalabras.Size = new System.Drawing.Size(162, 37);
            this.btnAddPalabras.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPalabras.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAddPalabras.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAddPalabras.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAddPalabras.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.btnAddPalabras.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddPalabras.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddPalabras.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddPalabras.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPalabras.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAddPalabras.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAddPalabras.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAddPalabras.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.btnAddPalabras.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddPalabras.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPalabras.TabIndex = 28;
            this.btnAddPalabras.Values.Text = "Agregar Palabras";
            this.btnAddPalabras.Click += new System.EventHandler(this.btnAddPalabras_Click);
            // 
            // frmAñadirMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.btnAddPalabras);
            this.Controls.Add(this.cmbPalabras);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.chkISBN);
            this.Controls.Add(this.chkISSN);
            this.Controls.Add(this.chkDOI);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbColeccion);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaPublicacion);
            this.Controls.Add(this.btnAgregarPortada);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.cmbIdiomas);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAñadirMaterial";
            this.Text = "frmAñadirMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdiomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPalabras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblNombre;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonLabel lblAutor;
        private Krypton.Toolkit.KryptonTextBox txtAutor;
        private Krypton.Toolkit.KryptonComboBox cmbIdiomas;
        private Krypton.Toolkit.KryptonLabel lblIdioma;
        private Krypton.Toolkit.KryptonTextBox txtEditorial;
        private Krypton.Toolkit.KryptonLabel lblEditorial;
        private System.Windows.Forms.PictureBox picPortada;
        private Krypton.Toolkit.KryptonButton btnAgregarPortada;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaPublicacion;
        private Krypton.Toolkit.KryptonLabel lblFecha;
        private Krypton.Toolkit.KryptonLabel lblFormato;
        private Krypton.Toolkit.KryptonLabel lblColeccion;
        private Krypton.Toolkit.KryptonComboBox cmbFormato;
        private Krypton.Toolkit.KryptonComboBox cmbColeccion;
        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private Krypton.Toolkit.KryptonCheckBox chkDOI;
        private Krypton.Toolkit.KryptonCheckBox chkISSN;
        private Krypton.Toolkit.KryptonCheckBox chkISBN;
        private Krypton.Toolkit.KryptonLabel lblEtiqueta;
        private Krypton.Toolkit.KryptonComboBox cmbPalabras;
        private Krypton.Toolkit.KryptonLabel lblPalabras;
        private Krypton.Toolkit.KryptonButton btnAddPalabras;
    }
}