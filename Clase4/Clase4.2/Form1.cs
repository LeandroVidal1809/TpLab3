using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(load2);
            
        }

        private void load2(object sender, EventArgs e)
        {
            txt1.KeyPress += new KeyPressEventHandler(textchange);
            button1.Click += new EventHandler(textchange);
            button1.Click += new EventHandler(borrar);
        
        }

        private void textchange(object sender, EventArgs e)
        {
            int salida;
            if (sender is TextBox)
            {
                
                   
                
                if(int.TryParse(((KeyPressEventArgs)e).KeyChar.ToString(),out salida)){} // VER
                         //MessageBox.Show("es Numero");
                
                        else
                          {
                              ((KeyPressEventArgs)e).Handled = true;
                          MessageBox.Show("Solo insertar numeros"); 
                            }
            }

            if (sender is Button)
            {
                MessageBox.Show("Es Boton");
                txt1.Clear();

            }
           }

        private void borrar(object sender, EventArgs e)
        {
            MessageBox.Show("Se borraron los datos");
        }
        }
    }

