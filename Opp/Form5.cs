using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Opp
{
    public partial class Form5 : Form
    {
        SqlConnection cn;
        SqlCommand comand;
        SqlDataAdapter adaptador;
        DataTable tabla;
        

        public Form5()
        {
            InitializeComponent();
        }
        

      
        
      

        private void Form5_Load(object sender, EventArgs e)
        {

            
            // TODO: esta línea de código carga datos en la tabla 'opp_FilmDataSet.Factura' Puede moverla o quitarla según sea necesario.
            // this.facturaTableAdapter.Fill(this.opp_FilmDataSet.Factura);
            
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                cConexion obj = new cConexion();
                obj.cargarData(dataGridView1, Convert.ToInt32(textBuscar.Text), 1);

            }
            catch
            {
                MessageBox.Show("Ingrese Correctamente el ID del cliente");

            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cConexion obj = new cConexion();
                obj.cargarData2(dataGridView1, Convert.ToInt32(textBuscar.Text));

            }
            catch
            {

                MessageBox.Show("Ingrese Correctamente el ID del cliente");
            }
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cConexion obj = new cConexion();
                obj.cargarData3(dataGridView1, 0);

            }
            catch
            {

                MessageBox.Show("Ingrese Correctamente el ID del cliente");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cConexion obj = new cConexion();
                obj.eliminarFacturas(dataGridView1, Convert.ToInt32(textBuscar.Text));
                MessageBox.Show("Las Facturas se eliminaron exitosamente");

            }
            catch {


                MessageBox.Show("Ingrese Correctamente el ID del cliente");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form6 obj = new Form6();
            obj.Show();

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void textBuscar_TextChanged(object sender, EventArgs e)
        {
        }

       
    }
}
