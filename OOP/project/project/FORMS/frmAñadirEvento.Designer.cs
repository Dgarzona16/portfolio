namespace project.FORMS
{
    partial class frmAñadirEvento
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
            this.txtTitulo = new Krypton.Toolkit.KryptonTextBox();
            this.lblTitulo = new Krypton.Toolkit.KryptonLabel();
            this.dtpFecha_Init = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaHora_Inicio = new Krypton.Toolkit.KryptonLabel();
            this.dtpHora_init = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblFechaHora_Fin = new Krypton.Toolkit.KryptonLabel();
            this.dtpFecha_Fin = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpHora_fin = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblParticipantes = new Krypton.Toolkit.KryptonLabel();
            this.nudCantParticipantes = new Krypton.Toolkit.KryptonNumericUpDown();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.cmbAreas = new Krypton.Toolkit.KryptonComboBox();
            this.lblArea = new Krypton.Toolkit.KryptonLabel();
            this.lblObjetivos = new Krypton.Toolkit.KryptonLabel();
            this.cmbObjetivos = new Krypton.Toolkit.KryptonComboBox();
            this.btnAgregarPortada = new project.CLASS.BButtons();
            this.btnAddObjetivos = new project.CLASS.BButtons();
            this.btnAgregar = new project.CLASS.BButtons();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(18, 89);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(309, 26);
            this.txtTitulo.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtTitulo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTitulo.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtTitulo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTitulo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Título del Evento";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(18, 41);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 28);
            this.lblTitulo.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Values.Text = "Título del Evento";
            this.lblTitulo.Visible = false;
            // 
            // dtpFecha_Init
            // 
            this.dtpFecha_Init.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha_Init.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha_Init.Location = new System.Drawing.Point(18, 241);
            this.dtpFecha_Init.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha_Init.Name = "dtpFecha_Init";
            this.dtpFecha_Init.Size = new System.Drawing.Size(152, 22);
            this.dtpFecha_Init.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFecha_Init.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Init.TabIndex = 2;
            this.dtpFecha_Init.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHora_Inicio
            // 
            this.lblFechaHora_Inicio.Location = new System.Drawing.Point(18, 178);
            this.lblFechaHora_Inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFechaHora_Inicio.Name = "lblFechaHora_Inicio";
            this.lblFechaHora_Inicio.Size = new System.Drawing.Size(222, 28);
            this.lblFechaHora_Inicio.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Inicio.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Inicio.TabIndex = 3;
            this.lblFechaHora_Inicio.Values.Text = "Fecha y hora de Inicio";
            // 
            // dtpHora_init
            // 
            this.dtpHora_init.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHora_init.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_init.Location = new System.Drawing.Point(225, 241);
            this.dtpHora_init.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHora_init.Name = "dtpHora_init";
            this.dtpHora_init.ShowUpDown = true;
            this.dtpHora_init.Size = new System.Drawing.Size(123, 22);
            this.dtpHora_init.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHora_init.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_init.TabIndex = 4;
            this.dtpHora_init.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHora_Fin
            // 
            this.lblFechaHora_Fin.Location = new System.Drawing.Point(18, 306);
            this.lblFechaHora_Fin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblFechaHora_Fin.Name = "lblFechaHora_Fin";
            this.lblFechaHora_Fin.Size = new System.Drawing.Size(286, 28);
            this.lblFechaHora_Fin.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Fin.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Fin.TabIndex = 5;
            this.lblFechaHora_Fin.Values.Text = "Fecha y hora de Finalización";
            // 
            // dtpFecha_Fin
            // 
            this.dtpFecha_Fin.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha_Fin.Location = new System.Drawing.Point(18, 378);
            this.dtpFecha_Fin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha_Fin.Name = "dtpFecha_Fin";
            this.dtpFecha_Fin.Size = new System.Drawing.Size(152, 22);
            this.dtpFecha_Fin.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFecha_Fin.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Fin.TabIndex = 6;
            this.dtpFecha_Fin.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // dtpHora_fin
            // 
            this.dtpHora_fin.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_fin.Location = new System.Drawing.Point(225, 378);
            this.dtpHora_fin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHora_fin.Name = "dtpHora_fin";
            this.dtpHora_fin.ShowUpDown = true;
            this.dtpHora_fin.Size = new System.Drawing.Size(123, 22);
            this.dtpHora_fin.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHora_fin.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_fin.TabIndex = 7;
            this.dtpHora_fin.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.Location = new System.Drawing.Point(436, 235);
            this.lblParticipantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(256, 28);
            this.lblParticipantes.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantes.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantes.TabIndex = 8;
            this.lblParticipantes.Values.Text = "Cantidad de participantes";
            // 
            // nudCantParticipantes
            // 
            this.nudCantParticipantes.Location = new System.Drawing.Point(436, 297);
            this.nudCantParticipantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantParticipantes.Name = "nudCantParticipantes";
            this.nudCantParticipantes.Size = new System.Drawing.Size(59, 22);
            this.nudCantParticipantes.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.nudCantParticipantes.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantParticipantes.TabIndex = 9;
            // 
            // picPortada
            // 
            this.picPortada.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picPortada.Location = new System.Drawing.Point(854, 41);
            this.picPortada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(335, 332);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 10;
            this.picPortada.TabStop = false;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(507, 663);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(456, 31);
            this.txtConfirmacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 13;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
            // 
            // cmbAreas
            // 
            this.cmbAreas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreas.DropDownWidth = 121;
            this.cmbAreas.IntegralHeight = false;
            this.cmbAreas.Location = new System.Drawing.Point(424, 89);
            this.cmbAreas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(348, 21);
            this.cmbAreas.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbAreas.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbAreas.TabIndex = 14;
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(424, 41);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(58, 28);
            this.lblArea.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.TabIndex = 15;
            this.lblArea.Values.Text = "Área";
            // 
            // lblObjetivos
            // 
            this.lblObjetivos.Location = new System.Drawing.Point(18, 461);
            this.lblObjetivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblObjetivos.Name = "lblObjetivos";
            this.lblObjetivos.Size = new System.Drawing.Size(103, 28);
            this.lblObjetivos.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivos.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivos.TabIndex = 16;
            this.lblObjetivos.Values.Text = "Objetivos";
            // 
            // cmbObjetivos
            // 
            this.cmbObjetivos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbObjetivos.DropDownWidth = 121;
            this.cmbObjetivos.IntegralHeight = false;
            this.cmbObjetivos.Location = new System.Drawing.Point(18, 509);
            this.cmbObjetivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbObjetivos.Name = "cmbObjetivos";
            this.cmbObjetivos.Size = new System.Drawing.Size(388, 21);
            this.cmbObjetivos.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbObjetivos.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivos.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbObjetivos.TabIndex = 17;
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
            this.btnAgregarPortada.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPortada.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregarPortada.Location = new System.Drawing.Point(876, 392);
            this.btnAgregarPortada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarPortada.Name = "btnAgregarPortada";
            this.btnAgregarPortada.Size = new System.Drawing.Size(293, 65);
            this.btnAgregarPortada.TabIndex = 31;
            this.btnAgregarPortada.Text = "AGREGAR UNA IMAGEN";
            this.btnAgregarPortada.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregarPortada.UseVisualStyleBackColor = false;
            this.btnAgregarPortada.Click += new System.EventHandler(this.btnAgregarPortada_Click_1);
            // 
            // btnAddObjetivos
            // 
            this.btnAddObjetivos.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddObjetivos.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btnAddObjetivos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddObjetivos.BorderRadius = 20;
            this.btnAddObjetivos.BorderSize = 0;
            this.btnAddObjetivos.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAddObjetivos.FlatAppearance.BorderSize = 0;
            this.btnAddObjetivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnAddObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddObjetivos.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObjetivos.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddObjetivos.Location = new System.Drawing.Point(436, 476);
            this.btnAddObjetivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddObjetivos.Name = "btnAddObjetivos";
            this.btnAddObjetivos.Size = new System.Drawing.Size(264, 58);
            this.btnAddObjetivos.TabIndex = 32;
            this.btnAddObjetivos.Text = "AGREGAR OBJETIVO";
            this.btnAddObjetivos.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAddObjetivos.UseVisualStyleBackColor = false;
            this.btnAddObjetivos.Click += new System.EventHandler(this.btnAddObjetivos_Click_1);
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
            this.btnAgregar.Location = new System.Drawing.Point(984, 639);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 58);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "AGREGAR EVENTO";
            this.btnAgregar.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // frmAñadirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(1264, 751);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAddObjetivos);
            this.Controls.Add(this.btnAgregarPortada);
            this.Controls.Add(this.cmbObjetivos);
            this.Controls.Add(this.lblObjetivos);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbAreas);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.picPortada);
            this.Controls.Add(this.nudCantParticipantes);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.dtpHora_fin);
            this.Controls.Add(this.dtpFecha_Fin);
            this.Controls.Add(this.lblFechaHora_Fin);
            this.Controls.Add(this.dtpHora_init);
            this.Controls.Add(this.lblFechaHora_Inicio);
            this.Controls.Add(this.dtpFecha_Init);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAñadirEvento";
            this.Text = "frmAñadirEvento";
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFecha_Init;
        private Krypton.Toolkit.KryptonLabel lblFechaHora_Inicio;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHora_init;
        private Krypton.Toolkit.KryptonLabel lblFechaHora_Fin;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFecha_Fin;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHora_fin;
        private Krypton.Toolkit.KryptonLabel lblParticipantes;
        private Krypton.Toolkit.KryptonNumericUpDown nudCantParticipantes;
        private System.Windows.Forms.PictureBox picPortada;
        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private Krypton.Toolkit.KryptonComboBox cmbAreas;
        private Krypton.Toolkit.KryptonLabel lblArea;
        private Krypton.Toolkit.KryptonLabel lblObjetivos;
        private Krypton.Toolkit.KryptonComboBox cmbObjetivos;
        private CLASS.BButtons btnAgregarPortada;
        private CLASS.BButtons btnAddObjetivos;
        private CLASS.BButtons btnAgregar;
    }
}