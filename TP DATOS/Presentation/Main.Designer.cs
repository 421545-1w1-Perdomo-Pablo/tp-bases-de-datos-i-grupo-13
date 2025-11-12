namespace TrabajoPracticoIntegrador
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnDash;
            System.Windows.Forms.Button btnGestor;
            System.Windows.Forms.Button btnResumen;
            System.Windows.Forms.Button btnSalir;
            System.Windows.Forms.Button btnAcercaDe;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            btnDash = new System.Windows.Forms.Button();
            btnGestor = new System.Windows.Forms.Button();
            btnResumen = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnAcercaDe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDash
            // 
            btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDash.ForeColor = System.Drawing.Color.White;
            btnDash.Location = new System.Drawing.Point(2, 165);
            btnDash.Margin = new System.Windows.Forms.Padding(2);
            btnDash.Name = "btnDash";
            btnDash.Size = new System.Drawing.Size(139, 33);
            btnDash.TabIndex = 1;
            btnDash.Text = "DASHBOARD";
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnGestor
            // 
            btnGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnGestor.FlatAppearance.BorderSize = 0;
            btnGestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGestor.ForeColor = System.Drawing.Color.White;
            btnGestor.Location = new System.Drawing.Point(2, 203);
            btnGestor.Margin = new System.Windows.Forms.Padding(2);
            btnGestor.Name = "btnGestor";
            btnGestor.Size = new System.Drawing.Size(139, 33);
            btnGestor.TabIndex = 2;
            btnGestor.Text = "GESTOR";
            btnGestor.UseVisualStyleBackColor = false;
            btnGestor.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnResumen
            // 
            btnResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnResumen.FlatAppearance.BorderSize = 0;
            btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnResumen.ForeColor = System.Drawing.Color.White;
            btnResumen.Location = new System.Drawing.Point(2, 240);
            btnResumen.Margin = new System.Windows.Forms.Padding(2);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new System.Drawing.Size(139, 33);
            btnResumen.TabIndex = 3;
            btnResumen.Text = "RESUMEN";
            btnResumen.UseVisualStyleBackColor = false;
            btnResumen.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSalir.ForeColor = System.Drawing.Color.White;
            btnSalir.Location = new System.Drawing.Point(2, 414);
            btnSalir.Margin = new System.Windows.Forms.Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(139, 33);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += new System.EventHandler(this.btnSalir);
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btnAcercaDe.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAcercaDe.ForeColor = System.Drawing.Color.White;
            btnAcercaDe.Location = new System.Drawing.Point(2, 378);
            btnAcercaDe.Margin = new System.Windows.Forms.Padding(2);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new System.Drawing.Size(139, 33);
            btnAcercaDe.TabIndex = 4;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = false;
            btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(btnAcercaDe);
            this.panel1.Controls.Add(btnSalir);
            this.panel1.Controls.Add(btnResumen);
            this.panel1.Controls.Add(btnGestor);
            this.panel1.Controls.Add(btnDash);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(143, 449);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(158, 121);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(476, 318);
            this.panelChildForm.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(640, 449);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complejo Canchas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

