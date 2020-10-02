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
    public partial class Form3 : Form
    {
        cConexion obj = new cConexion();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {

                
                MessageBox.Show(obj.insertarCliente(Convert.ToInt32(textUid.Text), textUname.Text, textUdireccion.Text, textUtel.Text, textUemail.Text, textUestatus.Text, Convert.ToDouble(textUmonto.Text)));
                MessageBox.Show(obj.insertarFactura(Convert.ToInt32(textUid.Text), Convert.ToDouble(textUmonto.Text)));

                Form4 obj1 = new Form4();
                obj1.Show();

                this.Hide();

            }
            catch
            {

                MessageBox.Show("Erro en la insercion de datos");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textUestatus.SelectedIndex = 0;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
