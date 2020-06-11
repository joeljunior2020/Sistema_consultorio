using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sistema_consultorio.FormPrincipal;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    public partial class FormMuestrasMedidas : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();



        public FormMuestrasMedidas()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMuestrasMedidas_Load(object sender, EventArgs e)
        {
            Llenar_DataGridView();
            int cantidad = dataGridView2.Rows.Count - 1;
            Total_lb.Text = cantidad.ToString();

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void guardar_modificar_MuestraMedica()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("MUESTRA_MEDICA_AGREGAR_MODIFICAR", con))
            {
                string muestra_id = "";
                if (txtID.Text == "")
                    muestra_id = "0";
                else
                    muestra_id = txtID.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_MUESTRA_MEDICA", SqlDbType.Int).Value = muestra_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@LABORATORIO", SqlDbType.NVarChar).Value = txtLaboratorio.Text;
                cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = txtCantidad.Text;
                cmd.Parameters.Add("@FECHA_VENCIMIENTO", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                //    cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkEstado.Checked;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            guardar_modificar_MuestraMedica();
            Llenar_DataGridView();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox2);
        }
        //////////////////////////////////////////
        private void Llenar_DataGridView()
        {
            //Los argumentos de conexion a la base de datos
            string args = "Data Source=.;Initial Catalog=Consultas;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                //Indico el SP que voy a utilizar
                SqlCommand command = new SqlCommand("SELECCIONAR_DATOS_MUESTRA_MEDICA", conn);
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
                dataGridView2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //////////////////////////////////////////////////////////////////
        public void seleccion_data_Muestra_medica()
        {
            try
            {
                txtID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtLaboratorio.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
               

                // checkEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            seleccion_data_Muestra_medica();
        }

        #region Filtrar_NOmbre
        public void FiltrarNombre()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_NOMBRE_MUESTRA_MEDICA", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView2.DataSource = dt;

                /////////////////////////////////////
                int cantidad = dataGridView2.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion

        ///////////////////////////

        #region Filtrar_ID
        public void Filtrar_ID()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_ID_MUESTRA_MEDICA", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView2.DataSource = dt;

                int cantidad = dataGridView2.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion

        ///////////////////////////

        #region Filtrar_Laboratorio
        public void Filtrar_laboratorio()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_LABORATORIO_MUESTRA_MEDICA", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@LABORATORIO", SqlDbType.NVarChar).Value = txtID.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView2.DataSource = dt;

                int cantidad = dataGridView2.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion



        ///////////////////////////

        #region Filtrar_F_Vencimiento
        public void Filtrar_F_Vencimiento()

        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("Filtrar_FECHA_VENCIMIENTO_MUESTRA_MEDICA", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FECHA_VENCIMIENTO", SqlDbType.NVarChar).Value = txtID.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                con.Open();

                //Aquí ejecuto el SP y lo lleno en el DataTable
                adapter.Fill(dt);

                //Enlazo mis datos obtenidos en el DataTable con el grid
                dataGridView2.DataSource = dt;

                int cantidad = dataGridView2.Rows.Count - 1;
                Total_lb.Text = cantidad.ToString();

                con.Close();

                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }

        #endregion

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            Filtrar_ID();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarNombre();
        }

        private void txtLaboratorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtrar_laboratorio();
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtrar_F_Vencimiento();
        }
    }
}
