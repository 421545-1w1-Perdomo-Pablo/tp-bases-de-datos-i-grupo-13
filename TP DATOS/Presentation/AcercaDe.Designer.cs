namespace TrabajoPracticoIntegrador.Presentacion
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAcercaDe_Salir = new System.Windows.Forms.Button();
            this.lblAcercaDe_texto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(154, 41);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Software desarrollado por:";
            // 
            // btnAcercaDe_Salir
            // 
            this.btnAcercaDe_Salir.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAcercaDe_Salir.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe_Salir.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe_Salir.Location = new System.Drawing.Point(191, 162);
            this.btnAcercaDe_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcercaDe_Salir.Name = "btnAcercaDe_Salir";
            this.btnAcercaDe_Salir.Size = new System.Drawing.Size(62, 33);
            this.btnAcercaDe_Salir.TabIndex = 2;
            this.btnAcercaDe_Salir.Text = "Continuar";
            this.btnAcercaDe_Salir.UseVisualStyleBackColor = false;
            this.btnAcercaDe_Salir.Click += new System.EventHandler(this.btnAcercaDe_Salir_Click);
            // 
            // lblAcercaDe_texto
            // 
            this.lblAcercaDe_texto.AutoSize = true;
            this.lblAcercaDe_texto.ForeColor = System.Drawing.Color.White;
            this.lblAcercaDe_texto.Location = new System.Drawing.Point(158, 71);
            this.lblAcercaDe_texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcercaDe_texto.Name = "lblAcercaDe_texto";
            this.lblAcercaDe_texto.Size = new System.Drawing.Size(51, 13);
            this.lblAcercaDe_texto.TabIndex = 3;
            this.lblAcercaDe_texto.Text = "Grupo 13";
            this.lblAcercaDe_texto.Click += new System.EventHandler(this.lblAcercaDe_texto_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(362, 206);
            this.Controls.Add(this.lblAcercaDe_texto);
            this.Controls.Add(this.btnAcercaDe_Salir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAcercaDe_Salir;
        private System.Windows.Forms.Label lblAcercaDe_texto;
    }
}