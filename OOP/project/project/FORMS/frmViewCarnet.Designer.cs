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
            ((System.ComponentModel.ISupportInitialize)(this.picFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // picFotografia
            // 
            this.picFotografia.BackColor = System.Drawing.Color.LightYellow;
            this.picFotografia.Location = new System.Drawing.Point(170, 27);
            this.picFotografia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFotografia.Name = "picFotografia";
            this.picFotografia.Size = new System.Drawing.Size(165, 169);
            this.picFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotografia.TabIndex = 0;
            this.picFotografia.TabStop = false;
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.LightYellow;
            this.picQR.Location = new System.Drawing.Point(105, 325);
            this.picQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(165, 169);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 1;
            this.picQR.TabStop = false;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.Location = new System.Drawing.Point(18, 18);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(110, 28);
            this.lblOcupacion.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.TabIndex = 2;
            this.lblOcupacion.Values.Text = "Ocupación";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(167, 507);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 33);
            this.lblId.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.TabIndex = 3;
            this.lblId.Values.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AllowDrop = true;
            this.lblNombre.AutoSize = false;
            this.lblNombre.Location = new System.Drawing.Point(18, 58);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblNombre.MaximumSize = new System.Drawing.Size(150, 231);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 129);
            this.lblNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Values.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(19, 257);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 28);
            this.lblEmail.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Values.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(18, 217);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 28);
            this.lblTelefono.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Values.Text = "Telefono";
            // 
            // frmViewCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.PrincipalBGYP;
            this.ClientSize = new System.Drawing.Size(378, 555);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.picFotografia);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}