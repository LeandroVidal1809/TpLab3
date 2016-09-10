using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(load);
        }

        private void load(object sender, EventArgs e)
        { 
            btn1.Click+=new EventHandler (clickbotones);
           
        }

        private void clickbotones(object sender, EventArgs e)
        {
           // MessageBox.Show("boton1");

            if (sender is Button)
            {
                switch (((Button)sender).Name)
                { 
                    case "btn1":
                            {
                                MessageBox.Show("Boton numero 1");
                                btn1.Click -= new EventHandler(clickbotones);
                                btn2.Click += new EventHandler(clickbotones);
                                break;
                            }
                    case "btn2":
                            {
                                MessageBox.Show("Boton numero 2");
                                btn2.Click -= new EventHandler(clickbotones);
                                btn3.Click += new EventHandler(clickbotones);
                                break;
                            }
                    case "btn3":
                            {
                                MessageBox.Show("Boton numero 3");
                                btn3.Click -= new EventHandler(clickbotones);
                                btn1.Click += new EventHandler(clickbotones);
                                break;
                            }

                }
            }
        }
    }
}
