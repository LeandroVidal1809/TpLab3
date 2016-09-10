using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load+= new EventHandler (cargar);
        }
        private void cargar(object sender, EventArgs evento)
        {
          
            btncargar.Click += new EventHandler (MostrarMensaje);
            btnDescargar.Click -= new EventHandler(descargar);
        }

        private void descargar(object sender, EventArgs evento)
        {
            btnDescargar.Click -= new EventHandler(MostrarMensaje);
        }
        private void MostrarMensaje(object sender, EventArgs evento)
        {

            MessageBox.Show("cargar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
