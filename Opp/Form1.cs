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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
      

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Form5 obj = new Form5();
            obj.Show();

            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();

            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();

            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
