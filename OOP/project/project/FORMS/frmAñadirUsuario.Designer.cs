namespace project.FORMS
{
    partial class frmAñadirUsuario
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
            this.txtDireccion = new Krypton.Toolkit.KryptonTextBox();
            this.lblDireccion = new Krypton.Toolkit.KryptonLabel();
            this.txtInstitucion = new Krypton.Toolkit.KryptonTextBox();
            this.lblInstitucion = new Krypton.Toolkit.KryptonLabel();
            this.txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            this.lblTelefono = new Krypton.Toolkit.KryptonLabel();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.lblCorreo = new Krypton.Toolkit.KryptonLabel();
            this.txtOcupacion = new Krypton.Toolkit.KryptonTextBox();
            this.lblOcupacion = new Krypton.Toolkit.KryptonLabel();
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.btnAgregar = new project.CLASS.BButtons();
            this.btnAgregarFotografia = new project.CLASS.BButtons();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(16, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(203, 28);
            this.lblNombre.StateCommon.LongText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Values.Text = "Nombre del Usuario";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 53);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 30);
            this.txtNombre.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtNombre.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNombre.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtNombre.StateActive.Content.Font = new System.Drawing.Font("Nunito ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtNombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtNombre.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtNombre.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre del Usuario";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(16, 231);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(275, 30);
            this.txtDireccion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtDireccion.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtDireccion.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtDireccion.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtDireccion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtDireccion.StateActive.Content.Font = new System.Drawing.Font("Nunito ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtDireccion.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtDireccion.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtDireccion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtDireccion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(16, 193);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(103, 28);
            this.lblDireccion.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Values.Text = "Dirección";
            this.lblDireccion.Visible = false;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Location = new System.Drawing.Point(16, 428);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(275, 30);
            this.txtInstitucion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtInstitucion.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtInstitucion.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtInstitucion.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtInstitucion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtInstitucion.StateActive.Content.Font = new System.Drawing.Font("Nunito ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtInstitucion.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtInstitucion.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtInstitucion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtInstitucion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstitucion.TabIndex = 9;
            this.txtInstitucion.Text = "Institución";
            this.txtInstitucion.Enter += new System.EventHandler(this.txtInstitucion_Enter);
            this.txtInstitucion.Leave += new System.EventHandler(this.txtInstitucion_Leave);
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(16, 390);
            this.lblInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(111, 28);
            this.lblInstitucion.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstitucion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstitucion.TabIndex = 8;
            this.lblInstitucion.Values.Text = "Institución";
            this.lblInstitucion.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(331, 53);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(275, 30);
            this.txtTelefono.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtTelefono.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTelefono.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTelefono.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTelefono.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtTelefono.StateActive.Content.Font = new System.Drawing.Font("Nunito ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtTelefono.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTelefono.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTelefono.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTelefono.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.Text = "Teléfono";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(331, 15);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(97, 28);
            this.lblTelefono.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Values.Text = "Teléfono";
            this.lblTelefono.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(331, 231);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(275, 30);
            this.txtCorreo.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtCorreo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtCorreo.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtCorreo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtCorreo.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtCorreo.StateActive.Content.Font = new System.Drawing.Font("Nunito ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtCorreo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtCorreo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtCorreo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtCorreo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Text = "Correo electrónico";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(331, 193);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(188, 28);
            this.lblCorreo.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Values.Text = "Correo electrónico";
            this.lblCorreo.Visible = false;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(331, 431);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(275, 30);
            this.txtOcupacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtOcupacion.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtOcupacion.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtOcupacion.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtOcupacion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtOcupacion.StateActive.Content.Font = new System.Drawing.Font("Nunito ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtOcupacion.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtOcupacion.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtOcupacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtOcupacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.TabIndex = 15;
            this.txtOcupacion.Text = "Ocupación";
            this.txtOcupacion.Enter += new System.EventHandler(this.txtOcupacion_Enter);
            this.txtOcupacion.Leave += new System.EventHandler(this.txtOcupacion_Leave);
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.Location = new System.Drawing.Point(331, 393);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(115, 28);
            this.lblOcupacion.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.TabIndex = 14;
            this.lblOcupacion.Values.Text = "Ocupación";
            this.lblOcupacion.Visible = false;
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picFotografia.Image = global::project.Properties.Resources.UserGoldIcon;
            this.picFotografia.Location = new System.Drawing.Point(739, 28);
            this.picFotografia.Margin = new System.Windows.Forms.Padding(4);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(276, 276);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 16;
            this.picFotografia.TabStop = false;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(379, 560);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
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
            this.btnAgregar.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.Location = new System.Drawing.Point(850, 532);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 59);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnAgregarFotografia
            // 
            this.btnAgregarFotografia.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarFotografia.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarFotografia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarFotografia.BorderRadius = 20;
            this.btnAgregarFotografia.BorderSize = 0;
            this.btnAgregarFotografia.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAgregarFotografia.FlatAppearance.BorderSize = 0;
            this.btnAgregarFotografia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnAgregarFotografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFotografia.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFotografia.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregarFotografia.Location = new System.Drawing.Point(741, 320);
            this.btnAgregarFotografia.Name = "btnAgregarFotografia";
            this.btnAgregarFotografia.Size = new System.Drawing.Size(273, 59);
            this.btnAgregarFotografia.TabIndex = 23;
            this.btnAgregarFotografia.Text = "Agregar Fotografía";
            this.btnAgregarFotografia.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregarFotografia.UseVisualStyleBackColor = false;
            this.btnAgregarFotografia.Click += new System.EventHandler(this.btnAgregarFotografia_Click_1);
            // 
            // frmAñadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 615);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAgregarFotografia);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.picFotografia);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtInstitucion);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAñadirUsuario";
            this.Text = "frmAñadirUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblNombre;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonTextBox txtDireccion;
        private Krypton.Toolkit.KryptonLabel lblDireccion;
        private Krypton.Toolkit.KryptonTextBox txtInstitucion;
        private Krypton.Toolkit.KryptonLabel lblInstitucion;
        private Krypton.Toolkit.KryptonTextBox txtTelefono;
        private Krypton.Toolkit.KryptonLabel lblTelefono;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Krypton.Toolkit.KryptonLabel lblCorreo;
        private Krypton.Toolkit.KryptonTextBox txtOcupacion;
        private Krypton.Toolkit.KryptonLabel lblOcupacion;
        private System.Windows.Forms.PictureBox picFotografia;
        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private CLASS.BButtons btnAgregarFotografia;
        private CLASS.BButtons btnAgregar;
    }
}