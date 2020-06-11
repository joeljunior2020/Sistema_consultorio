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
    public partial class FormConfiguracion : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();


        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            Llenar_DataGridViewENFERMEDAD();
            Llenar_DataGridViewEspecialidad();


            int cantidad_Enfermedad = dataGridViewEnfermedad.Rows.Count - 1;
            Total_lb_Enfermedad.Text = cantidad_Enfermedad.ToString();

            int cantidad_Especialidad = dataGridViewEspecialidad.Rows.Count - 1;
            Total_lb_Especialidad.Text = cantidad_Especialidad.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }





        ///////////////////especialidades///////////////////////////////
        public void guardar_modificar_especialidad()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("ESPECIALIDAD_AGREGAR_MODIFICAR", con))
            {
                string especialidad_id = "";
                if (txtIdEspecialidad.Text == "")
                    especialidad_id = "0";
                else
                    especialidad_id = txtIdEspecialidad.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_ESPECIALIDAD", SqlDbType.Int).Value = especialidad_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombreEspecialidad.Text;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
               

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        //////////////////////////////////Enfermedad///////////////////////////////////////////////////////////

        public void ENFERMEDADES_AGREGAR_MODIFICAR()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("ENFERMEDADES_AGREGAR_MODIFICAR", con))
            {
                string enfermedad_id = "";
                if (txtIdEnfermedad.Text == "")
                    enfermedad_id = "0";
                else
                    enfermedad_id = txtIdEnfermedad.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_ENFERMEDADES", SqlDbType.Int).Value = enfermedad_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombreEnfermedad.Text;
                cmd.Parameters.Add("@TIPO_ENFERMEDAD", SqlDbType.NVarChar).Value = txttipoEnfermdad.Text;
                // cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkBoxEnfermedad.Checked;


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        /////////////////////////////////////LLenar datagrid Enfermedad////////////////////////////////////////////
        private void Llenar_DataGridViewENFERMEDAD()
        {
            //Los argumentos de conexion a la base de datos
            string args = "Data Source=.;Initial Catalog=Consultas;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                //Indico el SP que voy a utilizar
                SqlCommand command = new SqlCommand("SELECCIONAR_DATOS_Enfermedad", conn);
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
                dataGridViewEnfermedad.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// //////////////////////////////////llenar datos especialidad//////////////////////////////////////
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
                dataGridViewEspecialidad.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button8_Click(object sender, EventArgs e)
        {
            guardar_modificar_especialidad();
            Llenar_DataGridViewEspecialidad();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdEnfermedad.Clear();
            txtNombreEnfermedad.Clear();
            checkEstado.Checked = false;
            txttipoEnfermdad.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarEnfermedad_Click(object sender, EventArgs e)
        {
            ENFERMEDADES_AGREGAR_MODIFICAR();
            Llenar_DataGridViewENFERMEDAD();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
        ///////////////////////////////SELECCIONAR DATA ESPECIALIDAD////////////////////////////////
        public void seleccion_data_especialidad()
        {
            try
            {
                txtIdEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells[0].Value.ToString();
                txtNombreEspecialidad.Text = dataGridViewEspecialidad.CurrentRow.Cells[1].Value.ToString();
                //txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //txtDireccion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //checkEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }
        ///////////////////////////////SELECCIONAR DATA Enfermedades////////////////////////////////
        public void seleccion_data_enfermedades()
        {
            try
            {
                txtIdEnfermedad.Text = dataGridViewEnfermedad.CurrentRow.Cells[0].Value.ToString();
                txtNombreEnfermedad.Text = dataGridViewEnfermedad.CurrentRow.Cells[1].Value.ToString();
                txttipoEnfermdad.Text = dataGridViewEnfermedad.CurrentRow.Cells[2].Value.ToString();
                checkBoxEnfermedad.Checked = Convert.ToBoolean(dataGridViewEnfermedad.CurrentRow.Cells[9].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            seleccion_data_especialidad();
        }

        private void dataGridViewEnfermedad_DoubleClick(object sender, EventArgs e)
        {
            seleccion_data_enfermedades();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtIdEspecialidad.Clear();
            txtNombreEspecialidad.Clear();
        }

        #region filtral datos ENFERMEDADES
        /// /////////////////////////////////////////////////
        #region Filtrar_ID
        public void Filtrar_ID_Enfermedades()

        {

            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_ID_ENFERMEDAD", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtIdEnfermedad.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridViewEnfermedad.DataSource = dt;

                int cantidad_Enfermedad = dataGridViewEnfermedad.Rows.Count - 1;
                Total_lb_Enfermedad.Text = cantidad_Enfermedad.ToString();

                con.Close();

            }

        }
        #endregion

        ////////////////////////////////////
        #region Filtrar_NOmbre_enfermedades
        public void FiltrarNombreEnfermedades()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_NOMBRE_ENFERMEDADES", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombreEnfermedad.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridViewEnfermedad.DataSource = dt;

                /////////////////////////////////////
                int cantidad_Enfermedad = dataGridViewEnfermedad.Rows.Count - 1;
                Total_lb_Enfermedad.Text = cantidad_Enfermedad.ToString();

                con.Close();
            }


        }
        #endregion
        /////////////////

        #region Filtrar_Tipo_enfermedad
        public void Filtrar_Tipo_enfermedad()

        {

            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_TIPO_ENFERMEDADES", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TIPO_ENFERMEDAD", SqlDbType.NVarChar).Value = txttipoEnfermdad.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridViewEnfermedad.DataSource = dt;

                int cantidad_Enfermedad = dataGridViewEnfermedad.Rows.Count - 1;
                Total_lb_Enfermedad.Text = cantidad_Enfermedad.ToString();

                con.Close();

            }

        }
        #endregion
        #endregion

        #region filtral datos ESPECIALIDAD
        /// /////////////////////////////////////////////////
        #region Filtrar_ID
        public void Filtrar_ID_Especialidad()

        {

            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_ID_ESPECIALIDAD", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtIdEspecialidad.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridViewEspecialidad.DataSource = dt;

                int cantidad_Especialidad = dataGridViewEspecialidad.Rows.Count - 1;
                Total_lb_Especialidad.Text = cantidad_Especialidad.ToString();

                con.Close();

            }

        }
        #endregion

        ////////////////////////////////////
        #region Filtrar_NOmbre_Especialidad
        public void FiltrarNombreEspecialidad()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_NOMBRE_ESPECIALIDAD", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombreEspecialidad.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridViewEspecialidad.DataSource = dt;

                /////////////////////////////////////
                int cantidad_Especialidad = dataGridViewEspecialidad.Rows.Count - 1;
                Total_lb_Especialidad.Text = cantidad_Especialidad.ToString();

                con.Close();
            }


        }



        #endregion

        #endregion

        private void txtIdEnfermedad_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_ID_Enfermedades();
        }

        private void txtNombreEnfermedad_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarNombreEnfermedades();
        }

        private void txttipoEnfermdad_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txttipoEnfermdad_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_Tipo_enfermedad();
        }

        private void txtIdEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNombreEspecialidad_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarNombreEspecialidad();
        }

        private void txtIdEspecialidad_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_ID_Especialidad();
        }
    }
}
