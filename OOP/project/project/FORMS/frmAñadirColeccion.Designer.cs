namespace project.FORMS
{
    partial class frmAñadirColeccion
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
            this.lblTipo = new Krypton.Toolkit.KryptonLabel();
            this.txtTipo = new Krypton.Toolkit.KryptonTextBox();
            this.txtGenero = new Krypton.Toolkit.KryptonTextBox();
            this.lblGenero = new Krypton.Toolkit.KryptonLabel();
            this.cmbAreas = new Krypton.Toolkit.KryptonComboBox();
            this.lblArea = new Krypton.Toolkit.KryptonLabel();
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.btnAgregar = new project.CLASS.BButtons();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(37, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(172, 23);
            this.lblNombre.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Values.Text = "Nombre de colección";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 22);
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
            this.txtNombre.Text = "Nombre de colección";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(37, 207);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(145, 23);
            this.lblTipo.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Values.Text = "Tipo de colección";
            this.lblTipo.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(37, 237);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(206, 22);
            this.txtTipo.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtTipo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTipo.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTipo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTipo.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtTipo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTipo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTipo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTipo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.TabIndex = 2;
            this.txtTipo.Text = "Tipo de colección";
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            this.txtTipo.Leave += new System.EventHandler(this.txtTipo_Leave);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(518, 101);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(206, 22);
            this.txtGenero.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtGenero.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtGenero.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtGenero.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtGenero.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtGenero.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtGenero.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtGenero.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtGenero.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.TabIndex = 3;
            this.txtGenero.Text = "Género de colección";
            this.txtGenero.Enter += new System.EventHandler(this.txtGenero_Enter);
            this.txtGenero.Leave += new System.EventHandler(this.txtGenero_Leave);
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(518, 70);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(168, 23);
            this.lblGenero.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Values.Text = "Género de colección";
            this.lblGenero.Visible = false;
            // 
            // cmbAreas
            // 
            this.cmbAreas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreas.DropDownWidth = 121;
            this.cmbAreas.IntegralHeight = false;
            this.cmbAreas.Location = new System.Drawing.Point(518, 243);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(265, 21);
            this.cmbAreas.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.LightYellow;
            this.cmbAreas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbAreas.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(518, 207);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 23);
            this.lblArea.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.TabIndex = 16;
            this.lblArea.Values.Text = "Área";
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(272, 339);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(273, 26);
            this.txtConfirmacion.StateActive.Back.Color1 = System.Drawing.Color.LightYellow;
            this.txtConfirmacion.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.txtConfirmacion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtConfirmacion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtConfirmacion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.TabIndex = 5;
            this.txtConfirmacion.Text = "Confirmar contraseña";
            this.txtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.Location = new System.Drawing.Point(292, 374);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(237, 41);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR COLECCIÓN";
            this.btnAgregar.TextColor = System.Drawing.Color.FloralWhite;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAñadirColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbAreas);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAñadirColeccion";
            this.Text = "frmAñadirColeccion";
            ((System.ComponentModel.ISupportInitialize)(this.cmbAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblNombre;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonLabel lblTipo;
        private Krypton.Toolkit.KryptonTextBox txtTipo;
        private Krypton.Toolkit.KryptonTextBox txtGenero;
        private Krypton.Toolkit.KryptonLabel lblGenero;
        private Krypton.Toolkit.KryptonComboBox cmbAreas;
        private Krypton.Toolkit.KryptonLabel lblArea;
        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private CLASS.BButtons btnAgregar;
    }
}