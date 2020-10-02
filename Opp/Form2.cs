using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opp
{
    public partial class Form2 : Form
    {
        cConexion obj = new cConexion();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(obj.pagoFactura(Convert.ToInt32(textCid.Text), comboBoxCpago.Text));

                Form1 obj1 = new Form1();
                obj1.Show();

                this.Hide();

            }
            catch
            {

                MessageBox.Show("Error en el pago");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();

            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxCpago.SelectedIndex = 0;
        }

       
    }
}
