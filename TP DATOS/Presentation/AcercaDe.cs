using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoIntegrador.Presentacion
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            AcercaDeTexto();
        }

        private void btnAcercaDe_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDeTexto()
        {
            string equipo = "Perdomo, Pablo José - 421545 \n" +
                            "Vela, Heber - 412029 \n" +
                            "Agregar nombres faltantes <-- BORRAR ESTO XD";

            lblAcercaDe_texto.Text = equipo;
        }

        private void lblAcercaDe_texto_Click(object sender, EventArgs e)
        {

        }
    }
}
