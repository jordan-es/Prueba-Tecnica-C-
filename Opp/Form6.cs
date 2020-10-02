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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 id = new Form5();


            cConexion obj = new cConexion();
            MessageBox.Show(obj.modificarFactura(Convert.ToInt32(textModID.Text), Convert.ToDouble(textModMonto.Text), monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy"), monthCalendar2.SelectionRange.Start.ToString("dd/MM/yyyy"), comboModEstado.Text));
           
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboModEstado.SelectedIndex = 0;
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
