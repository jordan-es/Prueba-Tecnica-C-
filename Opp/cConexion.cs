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
    class cConexion
    {
        
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            SqlDataAdapter adaptador;
            DataTable tabla;
            //public Double monto;

            public cConexion()
            {
                try
                {
                    cn = new SqlConnection("Data Source=.;Initial Catalog=OppDB;Integrated Security=True");
                    cn.Open();
                   // MessageBox.Show("Conexion Exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se conecto " + ex.ToString());

                }


            }



            public string pagoFactura(Int32 id_pago_factura, string tipoPago)
            {
                DateTime fechaPago = DateTime.Today;
                string salida = "El pago se realizo exitosamente mediante:" + tipoPago;
                int sql0;
                try
                {

                    cmd = new SqlCommand("INSERT INTO PagoFactura (id_pago_factura, tipo_pago, fecha_pago) values(" + id_pago_factura + ",'" + tipoPago + "','" + fechaPago + "')", cn);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("UPDATE Factura set estado = 'Cancelada' WHERE id_numero = " + id_pago_factura + " ", cn);
                    cmd.ExecuteNonQuery();

             

                }
                catch (Exception ex)
                {
                    salida = "Fallo del pago:" + ex.ToString();
                }
                return salida;

            }




            public string insertarCliente(Int32 id_cliente, String nombre, String direccion, String telefono, String email, String estatus, double monto)
            {

                string salida = "El usuario se creo perfectamente";
                try
                {

                    cmd = new SqlCommand("INSERT INTO Clientes (id_cliente, nombre, direccion, telefono, email, estatus) values(" + id_cliente + ",'" + nombre + "','" + direccion + "'," + telefono + ",'" + email + "','" + estatus + "')", cn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    salida = "Fallo de la creacion de usuario" ;
                }
                return salida;

            }


            public string insertarFactura(Int32 id_cliente, double monto)
            {
                DateTime fecha = DateTime.Now;
            //DateTime fechaV = fecha.AddMonths(1);

            var dateOnly = fecha.ToString("dd/MM/yyyy");
            

                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(2).AddDays(-1).ToString("dd/MM/yyyy");

                string salida = "La factura fue emitida el dia de hoy con fecha de vencimiento:" + endDate;
                try
                {

                    cmd = new SqlCommand("INSERT INTO Factura (id_numero, monto, fecha_creacion, fecha_vencimiento, estado) values(" + id_cliente + "," + monto + ",'" + dateOnly + "','" + endDate + "', 'Pendiente')", cn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    salida = "Fallo en la emision de factura:" ;
                }
                return salida;

            }


        public void cargarData(DataGridView dataGridView1, int nombre, int tipo)
        {
            try
            {

                adaptador = new SqlDataAdapter("SELECT Factura.id_numero as Numero_Factura, Clientes.nombre as Nombre_Cliente, Factura.monto as Monto, Factura.estado as Estado FROM dbo.Clientes, dbo.Factura WHERE Clientes.id_cliente ='"+nombre+"' AND Factura.id_numero= '"+nombre+"' ", cn);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch
            {



                MessageBox.Show("Ingrese correctamente el ID del cliente");
            }


        }


        public void cargarData2(DataGridView dataGridView1, int id_numero)
        {

            //DateTime fecha = DateTime.Today;
            try
            {

                adaptador = new SqlDataAdapter(" SELECT id_numero, monto, estado, (TRY_CONVERT(nchar, fecha_vencimiento, 103)) as FACTURA_VENCIDA FROM Factura WHERE fecha_vencimiento < GETDATE() AND Factura.estado = 'Pendiente' AND Factura.id_numero ='"+id_numero+"'", cn);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch
            {
                MessageBox.Show("No tiene facturas vencidas");
            }


        }

        public void cargarData3(DataGridView dataGridView1, int num)
        {
            num = 0;
            DateTime fecha = DateTime.Today;
           var fechas = fecha.ToString("dd/MM/yyyy");

           
            try
            {

                adaptador = new SqlDataAdapter(" SELECT id_numero, monto, estado, (TRY_CONVERT(datetime, fecha_vencimiento, 103)) as FACTURA_VENCIDA FROM Factura WHERE fecha_vencimiento < TRY_CONVERT(datetime, GETDATE()) AND estado = 'Pendiente' ORDER BY fecha_vencimiento ", cn);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch
            {
                MessageBox.Show("No tiene facturas vencidas");
            }


        }

        public void cargarData4(DataGridView dataGridView1)
        {
           


            try
            {

                adaptador = new SqlDataAdapter(" SELECT * FROM Clientes WHERE estatus = 'Activo'", cn);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch
            {
                MessageBox.Show("No tiene facturas vencidas");
            }


        }

        public void eliminarFacturas(DataGridView dataGridView1, int id_numero)
        {

           
            try
            {

                cmd = new SqlCommand("DELETE FROM Factura WHERE id_numero = '"+id_numero+"' ", cn);
                cmd.ExecuteNonQuery();

                adaptador = new SqlDataAdapter(" SELECT * FROM Factura where id_numero = '"+id_numero+"'", cn);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch
            {
                MessageBox.Show("Ingrese correctamente el ID del cliente");
            }


        }

        public void modFacturas(DataGridView dataGridView1, int id_numero)
        {


            try
            {

                cmd = new SqlCommand("DELETE FROM Factura WHERE id_numero = '" + id_numero + "' ", cn);
                cmd.ExecuteNonQuery();

                adaptador = new SqlDataAdapter(" SELECT * FROM Factura where id_numero = '" + id_numero + "'", cn);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch
            {
                MessageBox.Show("Ingrese correctamente el ID del cliente");
            }


        }

        public string modificarFactura(Int32 id_numero, double monto, String fecha, String fechav, String estado)
        {
           
            string salida = "La factura fue modificada con exito";
            try
            {

                cmd = new SqlCommand("UPDATE Factura SET monto = "+monto+", fecha_creacion = '"+fecha+"', fecha_vencimiento = '"+fechav+"', estado = '"+estado+"'  WHERE id_numero = "+id_numero+" ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Fallo la modificacion de la factura:" + ex.ToString();
            }
            return salida;

        }


































    }


    }

