using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            double monto = Int32.Parse(txtPrecio.Text);
            double dto;
            double total;

            if (monto < 30)
            { txtDto.Text = "$0.00"; txtTotal.Text = monto.ToString(); }
            else if (monto > 50)
            {
                dto = monto * 0.2;
                total = monto - dto;
                txtDto.Text = "$"+dto.ToString();
                txtTotal.Text = "$" + total.ToString();
            }
            else
            {
                dto = monto * 0.1;
                total = monto - dto;
                txtDto.Text = "$" + dto.ToString();
                txtTotal.Text = "$" + total.ToString();            
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) //ingresar con enter
            {
                btnGrabar_Click(sender,e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDto.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_AutoValidateChanged(object sender, EventArgs e)
        {

        }
    }
}
