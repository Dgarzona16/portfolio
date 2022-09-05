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
            this.dtpFechaPublicacion = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFecha = new Krypton.Toolkit.KryptonLabel();
            this.lblFormato = new Krypton.Toolkit.KryptonLabel();
            this.lblColeccion = new Krypton.Toolkit.KryptonLabel();
            this.cmbFormato = new Krypton.Toolkit.KryptonComboBox();
            this.cmbColeccion = new Krypton.Toolkit.KryptonComboBox();
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.chkDOI = new Krypton.Toolkit.KryptonCheckBox();
            this.chkISSN = new Krypton.Toolkit.KryptonCheckBox();
            this.chkISBN = new Krypton.Toolkit.KryptonCheckBox();
            this.lblEtiqueta = new Krypton.Toolkit.KryptonLabel();
            this.cmbPalabras = new Krypton.Toolkit.KryptonComboBox();
            this.lblPalabras = new Krypton.Toolkit.KryptonLabel();
            this.btnAgregarPortada = new project.CLASS.BButtons();
            this.btnAddPalabras = new project.CLASS.BButtons();
            this.btnAgregar = new project.CLASS.BButtons();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPalabras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(16, 28);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(205, 28);
            this.lblNombre.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Values.Text = "Nombre del Material";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 26);
            this.txtNombre.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtNombre.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNombre.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtNombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNombre.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre del Material";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblAutor
            // 
            this.lblAutor.Location = new System.Drawing.Point(16, 132);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(180, 28);
            this.lblAutor.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Values.Text = "Nombre del Autor";
            this.lblAutor.Visible = false;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(16, 170);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(275, 26);
            this.txtAutor.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtAutor.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtAutor.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtAutor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtAutor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtAutor.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.TabIndex = 2;
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
            this.cmbIdiomas.Location = new System.Drawing.Point(16, 379);
            this.cmbIdiomas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(227, 21);
            this.cmbIdiomas.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbIdiomas.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdiomas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbIdiomas.TabIndex = 4;
            // 
            // lblIdioma
            // 
            this.lblIdioma.Location = new System.Drawing.Point(16, 341);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(78, 28);
            this.lblIdioma.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.TabIndex = 8;
            this.lblIdioma.Values.Text = "Idioma";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(16, 272);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(275, 26);
            this.txtEditorial.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtEditorial.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtEditorial.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtEditorial.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtEditorial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtEditorial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.TabIndex = 3;
            this.txtEditorial.Text = "Nombre de Editorial";
            this.txtEditorial.Enter += new System.EventHandler(this.txtEditorial_Enter);
            this.txtEditorial.Leave += new System.EventHandler(this.txtEditorial_Leave);
            // 
            // lblEditorial
            // 
            this.lblEditorial.Location = new System.Drawing.Point(16, 234);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(202, 28);
            this.lblEditorial.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.TabIndex = 9;
            this.lblEditorial.Values.Text = "Nombre de Editorial";
            this.lblEditorial.Visible = false;
            // 
            // picPortada
            // 
            this.picPortada.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picPortada.Image = global::project.Properties.Resources.MaterialGoldIconWB;
            this.picPortada.Location = new System.Drawing.Point(764, 28);
            this.picPortada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(295, 265);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 11;
            this.picPortada.TabStop = false;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(391, 73);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(135, 22);
            this.dtpFechaPublicacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFechaPublicacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFechaPublicacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPublicacion.TabIndex = 6;
            this.dtpFechaPublicacion.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(391, 28);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(217, 28);
            this.lblFecha.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Values.Text = "Fecha de Publicacion";
            // 
            // lblFormato
            // 
            this.lblFormato.Location = new System.Drawing.Point(16, 423);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(93, 28);
            this.lblFormato.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.TabIndex = 15;
            this.lblFormato.Values.Text = "Formato";
            // 
            // lblColeccion
            // 
            this.lblColeccion.Location = new System.Drawing.Point(391, 132);
            this.lblColeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(108, 28);
            this.lblColeccion.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccion.TabIndex = 16;
            this.lblColeccion.Values.Text = "Coleccion";
            // 
            // cmbFormato
            // 
            this.cmbFormato.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.DropDownWidth = 192;
            this.cmbFormato.IntegralHeight = false;
            this.cmbFormato.Location = new System.Drawing.Point(16, 463);
            this.cmbFormato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(227, 21);
            this.cmbFormato.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbFormato.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormato.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFormato.TabIndex = 5;
            // 
            // cmbColeccion
            // 
            this.cmbColeccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccion.DropDownWidth = 121;
            this.cmbColeccion.IntegralHeight = false;
            this.cmbColeccion.Location = new System.Drawing.Point(391, 170);
            this.cmbColeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColeccion.Name = "cmbColeccion";
            this.cmbColeccion.Size = new System.Drawing.Size(256, 21);
            this.cmbColeccion.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbColeccion.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColeccion.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbColeccion.TabIndex = 7;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(764, 455);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(295, 31);
            this.txtConfirmacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtConfirmacion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 14;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
            // 
            // chkDOI
            // 
            this.chkDOI.Location = new System.Drawing.Point(391, 377);
            this.chkDOI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDOI.Name = "chkDOI";
            this.chkDOI.Size = new System.Drawing.Size(51, 24);
            this.chkDOI.TabIndex = 10;
            this.chkDOI.Values.Text = "DOI";
            // 
            // chkISSN
            // 
            this.chkISSN.Location = new System.Drawing.Point(391, 332);
            this.chkISSN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkISSN.Name = "chkISSN";
            this.chkISSN.Size = new System.Drawing.Size(57, 24);
            this.chkISSN.TabIndex = 9;
            this.chkISSN.Values.Text = "ISSN";
            // 
            // chkISBN
            // 
            this.chkISBN.Location = new System.Drawing.Point(391, 287);
            this.chkISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkISBN.Name = "chkISBN";
            this.chkISBN.Size = new System.Drawing.Size(57, 24);
            this.chkISBN.TabIndex = 8;
            this.chkISBN.Values.Text = "ISBN";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Location = new System.Drawing.Point(391, 234);
            this.lblEtiqueta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(103, 28);
            this.lblEtiqueta.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.TabIndex = 25;
            this.lblEtiqueta.Values.Text = "Etiquetas";
            // 
            // cmbPalabras
            // 
            this.cmbPalabras.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPalabras.DropDownWidth = 121;
            this.cmbPalabras.IntegralHeight = false;
            this.cmbPalabras.Location = new System.Drawing.Point(391, 463);
            this.cmbPalabras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPalabras.Name = "cmbPalabras";
            this.cmbPalabras.Size = new System.Drawing.Size(256, 21);
            this.cmbPalabras.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbPalabras.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPalabras.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbPalabras.TabIndex = 11;
            // 
            // lblPalabras
            // 
            this.lblPalabras.Location = new System.Drawing.Point(391, 425);
            this.lblPalabras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(154, 28);
            this.lblPalabras.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.TabIndex = 26;
            this.lblPalabras.Values.Text = "Palabras clave";
            // 
            // btnAgregarPortada
            // 
            this.btnAgregarPortada.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarPortada.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarPortada.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarPortada.BorderRadius = 20;
            this.btnAgregarPortada.BorderSize = 0;
            this.btnAgregarPortada.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarPortada.FlatAppearance.BorderSize = 0;
            this.btnAgregarPortada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnAgregarPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPortada.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregarPortada.Location = new System.Drawing.Point(764, 311);
            this.btnAgregarPortada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarPortada.Name = "btnAgregarPortada";
            this.btnAgregarPortada.Size = new System.Drawing.Size(295, 89);
            this.btnAgregarPortada.TabIndex = 13;
            this.btnAgregarPortada.Text = "AGREGAR UNA IMAGEN";
            this.btnAgregarPortada.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregarPortada.UseVisualStyleBackColor = false;
            this.btnAgregarPortada.Click += new System.EventHandler(this.btnAgregarPortada_Click_1);
            // 
            // btnAddPalabras
            // 
            this.btnAddPalabras.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddPalabras.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnAddPalabras.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddPalabras.BorderRadius = 20;
            this.btnAddPalabras.BorderSize = 0;
            this.btnAddPalabras.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAddPalabras.FlatAppearance.BorderSize = 0;
            this.btnAddPalabras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnAddPalabras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPalabras.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddPalabras.Location = new System.Drawing.Point(385, 495);
            this.btnAddPalabras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPalabras.Name = "btnAddPalabras";
            this.btnAddPalabras.Size = new System.Drawing.Size(266, 67);
            this.btnAddPalabras.TabIndex = 12;
            this.btnAddPalabras.Text = "AGREGAR PALABRAS";
            this.btnAddPalabras.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAddPalabras.UseVisualStyleBackColor = false;
            this.btnAddPalabras.Click += new System.EventHandler(this.btnAddPalabras_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.Location = new System.Drawing.Point(783, 495);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(257, 68);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "AGREGAR MATERIAL";
            this.btnAgregar.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // frmAñadirMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(1124, 615);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAddPalabras);
            this.Controls.Add(this.btnAgregarPortada);
            this.Controls.Add(this.cmbPalabras);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.chkISBN);
            this.Controls.Add(this.chkISSN);
            this.Controls.Add(this.chkDOI);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.cmbColeccion);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaPublicacion);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaPublicacion;
        private Krypton.Toolkit.KryptonLabel lblFecha;
        private Krypton.Toolkit.KryptonLabel lblFormato;
        private Krypton.Toolkit.KryptonLabel lblColeccion;
        private Krypton.Toolkit.KryptonComboBox cmbFormato;
        private Krypton.Toolkit.KryptonComboBox cmbColeccion;
        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private Krypton.Toolkit.KryptonCheckBox chkDOI;
        private Krypton.Toolkit.KryptonCheckBox chkISSN;
        private Krypton.Toolkit.KryptonCheckBox chkISBN;
        private Krypton.Toolkit.KryptonLabel lblEtiqueta;
        private Krypton.Toolkit.KryptonComboBox cmbPalabras;
        private Krypton.Toolkit.KryptonLabel lblPalabras;
        private CLASS.BButtons btnAgregarPortada;
        private CLASS.BButtons btnAddPalabras;
        private CLASS.BButtons btnAgregar;
    }
}