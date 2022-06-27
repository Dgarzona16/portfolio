namespace project.FORMS
{
    partial class frmDialogo
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
            this.txtConfirmacion = new Krypton.Toolkit.KryptonTextBox();
            this.btnValidar = new project.CLASS.BButtons();
            this.lblValidar = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(36, 83);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(401, 23);
            this.txtConfirmacion.TabIndex = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnValidar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnValidar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnValidar.BorderRadius = 8;
            this.btnValidar.BorderSize = 0;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(184, 125);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(116, 47);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.TextColor = System.Drawing.Color.White;
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblValidar
            // 
            this.lblValidar.Location = new System.Drawing.Point(174, 37);
            this.lblValidar.Name = "lblValidar";
            this.lblValidar.Size = new System.Drawing.Size(128, 20);
            this.lblValidar.TabIndex = 2;
            this.lblValidar.Values.Text = "Confirmar contraseña";
            // 
            // frmDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 189);
            this.Controls.Add(this.lblValidar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtConfirmacion);
            this.MaximizeBox = false;
            this.Name = "frmDialogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compruebe su contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtConfirmacion;
        private CLASS.BButtons btnValidar;
        private Krypton.Toolkit.KryptonLabel lblValidar;
    }
}