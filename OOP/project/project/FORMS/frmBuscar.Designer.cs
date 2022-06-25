namespace project.FORMS
{
    partial class frmBuscar
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
            this.txtBuscador = new Krypton.Toolkit.KryptonTextBox();
            this.cmbCatalogo = new Krypton.Toolkit.KryptonComboBox();
            this.dtgvResultado = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(16, 30);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(751, 35);
            this.txtBuscador.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtBuscador.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.txtBuscador.StateActive.Content.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // cmbCatalogo
            // 
            this.cmbCatalogo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatalogo.DropDownWidth = 167;
            this.cmbCatalogo.IntegralHeight = false;
            this.cmbCatalogo.Location = new System.Drawing.Point(805, 30);
            this.cmbCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCatalogo.Name = "cmbCatalogo";
            this.cmbCatalogo.Size = new System.Drawing.Size(279, 33);
            this.cmbCatalogo.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbCatalogo.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(44)))), ((int)(((byte)(95)))));
            this.cmbCatalogo.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Nunito Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatalogo.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatalogo.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.cmbCatalogo.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.cmbCatalogo.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.cmbCatalogo.StateTracking.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCatalogo.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cmbCatalogo.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cmbCatalogo.TabIndex = 1;
            // 
            // dtgvResultado
            // 
            this.dtgvResultado.AllowUserToAddRows = false;
            this.dtgvResultado.AllowUserToDeleteRows = false;
            this.dtgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultado.Location = new System.Drawing.Point(16, 101);
            this.dtgvResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvResultado.Name = "dtgvResultado";
            this.dtgvResultado.ReadOnly = true;
            this.dtgvResultado.RowHeadersWidth = 51;
            this.dtgvResultado.Size = new System.Drawing.Size(1068, 482);
            this.dtgvResultado.StateCommon.Background.Color1 = System.Drawing.Color.LightYellow;
            this.dtgvResultado.StateCommon.Background.Image = global::project.Properties.Resources.PrincipalBGYP;
            this.dtgvResultado.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtgvResultado.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtgvResultado.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtgvResultado.TabIndex = 2;
            this.dtgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvResultado_CellDoubleClick);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1124, 615);
            this.Controls.Add(this.dtgvResultado);
            this.Controls.Add(this.cmbCatalogo);
            this.Controls.Add(this.txtBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtBuscador;
        private Krypton.Toolkit.KryptonComboBox cmbCatalogo;
        private Krypton.Toolkit.KryptonDataGridView dtgvResultado;
    }
}