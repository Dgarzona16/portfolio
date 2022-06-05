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
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 54);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(206, 27);
            this.txtTitulo.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtTitulo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTitulo.StateActive.Content.Font = new System.Drawing.Font("Fira Code Retina", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtTitulo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(83)))), ((int)(((byte)(117)))));
            this.txtTitulo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.txtTitulo.StateCommon.Content.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Titulo del Evento";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 25);
            this.lblTitulo.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Values.Text = "Titulo del Evento";
            this.lblTitulo.Visible = false;
            // 
            // dtpFecha_Init
            // 
            this.dtpFecha_Init.Location = new System.Drawing.Point(12, 157);
            this.dtpFecha_Init.Name = "dtpFecha_Init";
            this.dtpFecha_Init.Size = new System.Drawing.Size(180, 21);
            this.dtpFecha_Init.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dtpFecha_Init.TabIndex = 2;
            this.dtpFecha_Init.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // lblFechaHora_Inicio
            // 
            this.lblFechaHora_Inicio.Location = new System.Drawing.Point(12, 115);
            this.lblFechaHora_Inicio.Name = "lblFechaHora_Inicio";
            this.lblFechaHora_Inicio.Size = new System.Drawing.Size(229, 25);
            this.lblFechaHora_Inicio.StateCommon.LongText.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Inicio.StateCommon.ShortText.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora_Inicio.TabIndex = 3;
            this.lblFechaHora_Inicio.Values.Text = "Fecha y hora de Inicio";
            this.lblFechaHora_Inicio.Visible = true;
            // 
            // dtpHora_init
            // 
            this.dtpHora_init.CalendarDayStyle = Krypton.Toolkit.ButtonStyle.ListItem;
            this.dtpHora_init.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora_init.ShowUpDown = true;
            this.dtpHora_init.Location = new System.Drawing.Point(233, 157);
            this.dtpHora_init.Name = "dtpHora_init";
            this.dtpHora_init.Size = new System.Drawing.Size(82, 21);
            this.dtpHora_init.TabIndex = 4;
            this.dtpHora_init.ValueNullable = new System.DateTime(2022, 6, 3, 21, 13, 4, 0);
            // 
            // frmAñadirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.dtpHora_init);
            this.Controls.Add(this.lblFechaHora_Inicio);
            this.Controls.Add(this.dtpFecha_Init);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAñadirEvento";
            this.Text = "frmAñadirEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTitulo;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFecha_Init;
        private Krypton.Toolkit.KryptonLabel lblFechaHora_Inicio;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHora_init;
    }
}