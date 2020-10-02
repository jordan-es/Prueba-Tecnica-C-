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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'oppDBDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.oppDBDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'opp_FilmDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.opp_FilmDataSet.Clientes);



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.clientesTableAdapter.FillBy(this.opp_FilmDataSet.Clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.Show();

            this.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.clientesTableAdapter.FillBy1(this.OppDBDataSet.Clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cConexion obj = new cConexion();
            obj.cargarData4(dataGridView1);
        }
    }
}
