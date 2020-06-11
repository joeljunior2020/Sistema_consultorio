using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    public partial class FormMedico : Form
    {

        ///crando instancia de la clase validacion
        Validacion v = new Validacion();



        public FormMedico()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            Llenar_DataGridView();
            int cantidad = dataGridView1.Rows.Count - 1;
            Total_lb.Text = cantidad.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Especialidades FrmEspecialides = new Especialidades();
            FrmEspecialides.Show();
        }

     
        /// //////////////////////////////////////////////////////////////
  

        public void DOCTOR_AGREGAR_MODIFICAR()
        {
           
            try
            {
                SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
                using (SqlCommand cmd = new SqlCommand("DOCTOR_AGREGAR_MODIFICAR", con))
                {
                    string Doctor_id = "";
                    if (txtID.Text == "")
                        Doctor_id = "0";
                    else
                        Doctor_id = txtID.Text;
                    //Mayuscula(); crear el metood para mayusculas

                    string Sexo;
                    if (cboSexo.Text == "MASCULINO")
                    {
                        Sexo = "M";
                    }
                    else
                    {
                        Sexo = "F";
                    }

                    DateTime today = DateTime.Today; // optenr la fecha actual

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID_DOCTOR", SqlDbType.Int).Value = Doctor_id;
                    cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@APELLIDO", SqlDbType.NVarChar).Value = txtApellido.Text;
                    cmd.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = txtTelefono.Text;
                    cmd.Parameters.Add("@CEDULA", SqlDbType.NVarChar).Value = txtCedula.Text;
                    cmd.Parameters.Add("@SEXO ", SqlDbType.Char).Value = Sexo;
                    cmd.Parameters.Add("@EMAIL ", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkEstado.Checked;
                    cmd.Parameters.Add("@FECHA_REGISTRO ", SqlDbType.DateTime).Value = today;
                    cmd.Parameters.Add("@ID_ESPECIALIDAD ", SqlDbType.Int).Value = cboEspecialidad.Text;
                    cmd.Parameters.Add("@ID_USUARIO ", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;

                 
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();






                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            DOCTOR_AGREGAR_MODIFICAR();
            Llenar_DataGridView();
        }




        ///////////////////MOSTRAR DATOS DATAGRIDVIEW/////////////////////////

    

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox2);
        }

        ////////////////////////////////////LL///////////////////////////////////////

        private void Llenar_DataGridView()
        {
            //Los argumentos de conexion a la base de datos
            string args = "Data Source=.;Initial Catalog=Consultas;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                //Indico el SP que voy a utilizar
                SqlCommand command = new SqlCommand("SELECCIONAR_DATOS_DOCTOR", conn);
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
        /////////////////////////////////////////////////////////////////////////////
        public void seleccion_data_Doctor()
        {

            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
            {

                try
                {
                    txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    cboSexo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    checkEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    cboEspecialidad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            seleccion_data_Doctor();
        }

        /// ///////////////////////////
       
        #region Filtrar_NOmbre
        public void FiltrarNombre()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_NOMBRE_DOCTOR", con))
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
            using (SqlCommand cmd = new SqlCommand("Filtrar_Apellido_Doctor", con))
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
            using (SqlCommand cmd = new SqlCommand("Filtrar_ID_DOCTOR", con))
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
            using (SqlCommand cmd = new SqlCommand("Filtrar_CEDULA_Doctor", con))
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

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_ID();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarNombre();
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_Apellido();
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_Cedula();
        }
        #endregion

        /// ////////////////////////////////////////











    }

}
