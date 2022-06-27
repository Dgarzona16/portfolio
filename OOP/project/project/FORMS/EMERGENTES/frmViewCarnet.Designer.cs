namespace project.FORMS
{
    partial class frmViewCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCarnet));
            this.picFotografia = new System.Windows.Forms.PictureBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblOcupacion = new Krypton.Toolkit.KryptonLabel();
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            this.lblNombre = new Krypton.Toolkit.KryptonLabel();
            this.lblEmail = new Krypton.Toolkit.KryptonLabel();
            this.lblTelefono = new Krypton.Toolkit.KryptonLabel();
            this.lblInstitucion = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.Color.LightYellow;
            this.picFotografia.Location = new System.Drawing.Point(113, 18);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(110, 110);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 0;
            this.picFotografia.TabStop = false;
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.LightYellow;
            this.picQR.Location = new System.Drawing.Point(70, 211);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(110, 110);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 1;
            this.picQR.TabStop = false;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.Location = new System.Drawing.Point(12, 108);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(81, 20);
            this.lblOcupacion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.TabIndex = 2;
            this.lblOcupacion.Values.Text = "Ocupación";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(111, 330);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 23);
            this.lblId.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.TabIndex = 3;
            this.lblId.Values.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AllowDrop = true;
            this.lblNombre.AutoSize = false;
            this.lblNombre.Location = new System.Drawing.Point(12, 18);
            this.lblNombre.MaximumSize = new System.Drawing.Size(100, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 84);
            this.lblNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Values.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(12, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Values.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(12, 164);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 20);
            this.lblTelefono.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Values.Text = "Telefono";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.Location = new System.Drawing.Point(12, 138);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(77, 20);
            this.lblInstitucion.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstitucion.TabIndex = 7;
            this.lblInstitucion.Values.Text = "Institucion";
            // 
            // frmViewCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(252, 361);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.picFotografia);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "frmViewCarnet";
            this.Text = "Carnet";
            this.Load += new System.EventHandler(this.frmViewCarnet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFotografia;
        private System.Windows.Forms.PictureBox picQR;
        private Krypton.Toolkit.KryptonLabel lblOcupacion;
        private Krypton.Toolkit.KryptonLabel lblId;
        private Krypton.Toolkit.KryptonLabel lblNombre;
        private Krypton.Toolkit.KryptonLabel lblEmail;
        private Krypton.Toolkit.KryptonLabel lblTelefono;
        private Krypton.Toolkit.KryptonLabel lblInstitucion;
    }
}