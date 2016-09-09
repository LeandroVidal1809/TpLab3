using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i;
            int tot;
            int num = Int32.Parse(txtNumero.Text);
            for (i = 1; i < 10; i++)
            { 
                
                tot=i * num;

                lstTabla.Items.Add(i +"*"+ txtNumero.Text + "="+tot); 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            txtNumero.Text = "";
            lstTabla.Items.Clear();
         }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Realmente Desea Salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        }
    }
