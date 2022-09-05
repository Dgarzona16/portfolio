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
            this.txtTitulo.Location = new System.Drawing.Point(12, 58);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(206, 22);
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
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Título del Evento";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 23);
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
            this.dtpFecha_Init.Location = new System.Drawing.Point(12, 157);
            this.dtpFecha_Init.Name = "dtpFecha_Init";
            this.dtpFecha_Init.Size = new System.Drawing.Size(101, 18);
            this.dtpFecha_Init.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFecha_Init.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Init.TabIndex = 2;
            this.dtpFecha_Init.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHora_Inicio
            // 
            this.lblFechaHora_Inicio.Location = new System.Drawing.Point(12, 116);
            this.lblFechaHora_Inicio.Name = "lblFechaHora_Inicio";
            this.lblFechaHora_Inicio.Size = new System.Drawing.Size(179, 23);
            this.lblFechaHora_Inicio.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Inicio.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Inicio.TabIndex = 3;
            this.lblFechaHora_Inicio.Values.Text = "Fecha y hora de Inicio";
            // 
            // dtpHora_init
            // 
            this.dtpHora_init.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHora_init.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_init.Location = new System.Drawing.Point(150, 157);
            this.dtpHora_init.Name = "dtpHora_init";
            this.dtpHora_init.ShowUpDown = true;
            this.dtpHora_init.Size = new System.Drawing.Size(82, 18);
            this.dtpHora_init.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHora_init.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_init.TabIndex = 3;
            this.dtpHora_init.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHora_Fin
            // 
            this.lblFechaHora_Fin.Location = new System.Drawing.Point(12, 199);
            this.lblFechaHora_Fin.Name = "lblFechaHora_Fin";
            this.lblFechaHora_Fin.Size = new System.Drawing.Size(230, 23);
            this.lblFechaHora_Fin.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Fin.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Fin.TabIndex = 5;
            this.lblFechaHora_Fin.Values.Text = "Fecha y hora de Finalización";
            // 
            // dtpFecha_Fin
            // 
            this.dtpFecha_Fin.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha_Fin.Location = new System.Drawing.Point(12, 246);
            this.dtpFecha_Fin.Name = "dtpFecha_Fin";
            this.dtpFecha_Fin.Size = new System.Drawing.Size(101, 18);
            this.dtpFecha_Fin.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpFecha_Fin.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha_Fin.TabIndex = 4;
            this.dtpFecha_Fin.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // dtpHora_fin
            // 
            this.dtpHora_fin.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_fin.Location = new System.Drawing.Point(150, 246);
            this.dtpHora_fin.Name = "dtpHora_fin";
            this.dtpHora_fin.ShowUpDown = true;
            this.dtpHora_fin.Size = new System.Drawing.Size(82, 18);
            this.dtpHora_fin.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.dtpHora_fin.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora_fin.TabIndex = 5;
            this.dtpHora_fin.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.Location = new System.Drawing.Point(283, 199);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(206, 23);
            this.lblParticipantes.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantes.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantes.TabIndex = 8;
            this.lblParticipantes.Values.Text = "Cantidad de participantes";
            // 
            // nudCantParticipantes
            // 
            this.nudCantParticipantes.Location = new System.Drawing.Point(283, 239);
            this.nudCantParticipantes.Name = "nudCantParticipantes";
            this.nudCantParticipantes.Size = new System.Drawing.Size(48, 19);
            this.nudCantParticipantes.StateCommon.Back.Color1 = System.Drawing.Color.LightYellow;
            this.nudCantParticipantes.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantParticipantes.TabIndex = 9;
            // 
            // picPortada
            // 
            this.picPortada.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picPortada.Image = global::project.Properties.Resources.EventGoldIcon;
            this.picPortada.Location = new System.Drawing.Point(571, 57);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(223, 216);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPortada.TabIndex = 10;
            this.picPortada.TabStop = false;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(545, 355);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(274, 26);
            this.txtConfirmacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtConfirmacion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 11;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
            // 
            // cmbAreas
            // 
            this.cmbAreas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreas.DropDownWidth = 121;
            this.cmbAreas.IntegralHeight = false;
            this.cmbAreas.Location = new System.Drawing.Point(283, 58);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(232, 18);
            this.cmbAreas.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbAreas.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbAreas.TabIndex = 8;
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(283, 27);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 23);
            this.lblArea.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.TabIndex = 15;
            this.lblArea.Values.Text = "Área";
            // 
            // lblObjetivos
            // 
            this.lblObjetivos.Location = new System.Drawing.Point(12, 324);
            this.lblObjetivos.Name = "lblObjetivos";
            this.lblObjetivos.Size = new System.Drawing.Size(84, 23);
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
            this.cmbObjetivos.Location = new System.Drawing.Point(12, 355);
            this.cmbObjetivos.Name = "cmbObjetivos";
            this.cmbObjetivos.Size = new System.Drawing.Size(259, 18);
            this.cmbObjetivos.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbObjetivos.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivos.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbObjetivos.TabIndex = 6;
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
            this.btnAgregarPortada.Location = new System.Drawing.Point(571, 285);
            this.btnAgregarPortada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarPortada.Name = "btnAgregarPortada";
            this.btnAgregarPortada.Size = new System.Drawing.Size(223, 42);
            this.btnAgregarPortada.TabIndex = 10;
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
            this.btnAddObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObjetivos.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddObjetivos.Location = new System.Drawing.Point(12, 391);
            this.btnAddObjetivos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddObjetivos.Name = "btnAddObjetivos";
            this.btnAddObjetivos.Size = new System.Drawing.Size(238, 38);
            this.btnAddObjetivos.TabIndex = 7;
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
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.Location = new System.Drawing.Point(598, 398);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 38);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR EVENTO";
            this.btnAgregar.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // frmAñadirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(843, 488);
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