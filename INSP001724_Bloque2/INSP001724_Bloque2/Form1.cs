using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSP001724_Bloque2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Form2 ventana2 = new Form2();
        Form3 ventana3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ventana2 == null || ventana2.IsDisposed)
            {
                ventana2 = new Form2();
            }
            ventana2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ventana3 == null || ventana3.IsDisposed)
            {
                ventana3 = new Form3();
            }
            ventana3.Show();
        }
    }
}
