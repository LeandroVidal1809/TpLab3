using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion9Estacionamiento
{
    public partial class FrmPrincipal : Form
    {
        FrmGestionAutomovil FrmGestion;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.BackgroundImage = Properties.Resources.industrial_garage_door;
            this.Icon = Properties.Resources.user3;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AcercaDe = new AboutBox1();
            AcercaDe.ShowDialog();
           
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmGestion == null)
            {
                FrmGestion = new FrmGestionAutomovil();
                FrmGestion.MdiParent = this;
                FrmGestion.Show();
                this.menuStrip1.AllowMerge = false;
                FrmGestion.Dock = DockStyle.Fill;//Ubica la posicion de la ventana en su ventana contenedor
                
                //FrmGestion.WindowState = FormWindowState.Maximized;//muestra la ventana maximizada , minimizada o normal

                FrmGestion.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//Estilo del borde del formulario
            }
        }
    }
}
