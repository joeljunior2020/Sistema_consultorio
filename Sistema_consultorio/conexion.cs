using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Sistema_consultorio
{
    class Conexion
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Consultas;Integrated Security=True");


        public void Conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado");

            }
            catch
            {
                MessageBox.Show("Error al conectar");

            }
            finally
            {
                con.Close();
            }
        }


    }
}
