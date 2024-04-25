using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cuenta.TextLength < 5)
            {
                Cuenta.Text = Cuenta.Text + "1";
            }
            else
            {
                MessageBox.Show("El No. de Cuenta tiene 5 digitos");
            }
            if (NIP.TextLength < 4)
            {
                NIP.Text = NIP.Text + "1";
            }
            else
            {
                MessageBox.Show("El NIP tiene 4 digitos");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //cierra la aplicacion
            Application.Exit();
        }
    }
}
