using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    public partial class Especialidades : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();


        public Especialidades()
        {
            InitializeComponent();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            Llenar_DataGridViewEspecialidad();
            int cantidad = dataGridView3.Rows.Count - 1;
            Total_lb.Text = cantidad.ToString();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        public void guardar_modificar_especialidad()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("ESPECIALIDAD_AGREGAR_MODIFICAR", con))
            {
                string especialidad_id = "";
                if (txtID.Text == "")
                    especialidad_id = "0";
                else
                    especialidad_id = txtID.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_ESPECIALIDAD", SqlDbType.Int).Value = especialidad_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar_modificar_especialidad();
            Llenar_DataGridViewEspecialidad();
        }

        /////////////////////////////////////////////////////////////////////




        private void Llenar_DataGridViewEspecialidad()
        {
            //Los argumentos de conexion a la base de datos
            string args = "Data Source=.;Initial Catalog=Consultas;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                //Indico el SP que voy a utilizar
                SqlCommand command = new SqlCommand("SELECCIONAR_DATOS_ESPECIALIDAD", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                ////Envió los parámetros que necesito
                //SqlParameter param = new SqlParameter("@percentage", SqlDbType.Int);
                //param.Value = 100;
                //command.Parameters.Add(param);

                DataTable dt = new DataTable();

                conn.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
        }

        /// /////////////////////////////////////////////////
        #region Filtrar_ID
        public void Filtrar_ID()

        {

            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_ID_ESPECIALIDAD", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView3.DataSource = dt;

                int cantidad = dataGridView3.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }

        }
        #endregion

        ////////////////////////////////////
        #region Filtrar_NOmbre
        public void FiltrarNombre()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_NOMBRE_ESPECIALIDAD", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView3.DataSource = dt;

                /////////////////////////////////////
                int cantidad = dataGridView3.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion

        private void btnGuardar_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_ID();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarNombre();
        }



    }
}