using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoIntegrador.Presentacion;

namespace TrabajoPracticoIntegrador
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void abrirChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitulo.Text = childForm.Text;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Presentation.Placeholder());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Presentation.Placeholder());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Presentation.Placeholder());
        }

        private void btnSalir(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { 
                this.Close();
            }
        }

        private void AbrirVentana(Form childForm)
        {
            childForm.Show();
        }

        private void btnAcercaDe(object sender, EventArgs e)
        {
            AbrirVentana(new Presentacion.AcercaDe());
        }
    }
}
