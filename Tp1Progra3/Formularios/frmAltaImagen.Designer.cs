namespace Tp1Progra3
{
    partial class frmAltaImagen
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
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblIngresarURLImagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(12, 45);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(510, 20);
            this.txtUrlImagen.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(227, 71);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblIngresarURLImagen
            // 
            this.lblIngresarURLImagen.AutoSize = true;
            this.lblIngresarURLImagen.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarURLImagen.Location = new System.Drawing.Point(184, 9);
            this.lblIngresarURLImagen.Name = "lblIngresarURLImagen";
            this.lblIngresarURLImagen.Size = new System.Drawing.Size(167, 20);
            this.lblIngresarURLImagen.TabIndex = 2;
            this.lblIngresarURLImagen.Text = "Ingresar URL Imagen";
            // 
            // frmAltaImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 130);
            this.Controls.Add(this.lblIngresarURLImagen);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtUrlImagen);
            this.Name = "frmAltaImagen";
            this.Text = "frmAltaImagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblIngresarURLImagen;
    }
}