using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_consultorio.FormPrincipal;

namespace Sistema_consultorio
{


    public partial class FormPaciente : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();

      
        public FormPaciente()
        {
            InitializeComponent();
   
        }
      

        Conexion con = new Conexion();


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this,groupBox2);
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            guardar_pasiente();
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            Llenar_DataGridView();

       int  cantidad  =  dataGridView1.Rows.Count - 1;
      Total_lb.Text = cantidad.ToString();



        }


        public void guardar_pasiente()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("PACIENTE_AGREGAR_MODIFICAR",con))
            {
                string paciente_id = "";
                if (txtID.Text == "")
                    paciente_id = "0";
                else
                    paciente_id = txtID.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                string Sexo;
                if (cboSexo.Text == "MASCULINO")
                {
                    Sexo = "M";
                }
                else
                {
                    Sexo = "F";
                }


                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = paciente_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@APELLIDO", SqlDbType.NVarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("@CEDULA", SqlDbType.NVarChar).Value = txtCedula.Text;
                cmd.Parameters.Add("@SEGURO", SqlDbType.NVarChar).Value = txtSeguro.Text;
                cmd.Parameters.Add("@FECHA_NACIMIENTO ", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@SEXO ", SqlDbType.Char).Value = Sexo;
                cmd.Parameters.Add("@DIRECCION ", SqlDbType.NVarChar).Value = txtDireccion.Text;
                cmd.Parameters.Add("@TELEFONO ", SqlDbType.NVarChar).Value = txtTelefono.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkEstado.Checked;
                cmd.Parameters.Add("ID_LICENCIA", SqlDbType.Int).Value = DatosGlobales.ID_LICENCIA_GLOBAL;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;
     
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Llenar_DataGridView();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }
      


        private void k(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }
        /////////////////////////////////////////////////////////

        private void Llenar_DataGridView()
        {
            //Los argumentos de conexion a la base de datos
            string args = "Data Source=.;Initial Catalog=Consultas;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                //Indico el SP que voy a utilizar
                SqlCommand command = new SqlCommand("SELECCIONAR_DATOS_PACIENTES", conn);
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
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        


        public void seleccion_data_paciente()
        {

          if (  dataGridView1.CurrentRow.Cells[0].Value.ToString() != "" )
            { 

            try
            {

                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtSeguro.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cboSexo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                checkEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[10].Value.ToString());

                //   txtTelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }

            }

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void FormPaciente_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            seleccion_data_paciente();
        }

        ///////////////////////FILTRAR DATOS///////////////////////////////////////////////////////
        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_ID();

        }



 
        /// ///////////////////////////
       
        #region Filtrar_NOmbre
        public void FiltrarNombre()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_nombre", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView1.DataSource = dt;

                /////////////////////////////////////
                int cantidad = dataGridView1.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();
           
                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion
        /// ////////////////////////////////////////////////////////
         #region Filtrar_apellido
        public void Filtrar_Apellido()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_Apellido_Paciente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView1.DataSource = dt;

                int cantidad = dataGridView1.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion

        /////////////////////////////

        #region Filtrar_ID
        public void Filtrar_ID()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_ID_PACIENTE", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView1.DataSource = dt;

                int cantidad = dataGridView1.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion
        /// /////////////////////////////////////////////////

        #region Filtrar_cedula
        public void Filtrar_Cedula()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_CEDULAA_PACIENTE", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CEDULA", SqlDbType.NVarChar).Value = txtCedula.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView1.DataSource = dt;

                int cantidad = dataGridView1.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion



        /// ////////////////////////////////////////
       



        ///////////////////////////////////////////////////////

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarNombre();
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_Cedula();
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_Apellido();
        }

        private void Total_lb_Click(object sender, EventArgs e)
        {

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }
    }
}
