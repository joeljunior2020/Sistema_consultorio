using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    public partial class FormAseguradora : Form
    {

        ///crando instancia de la clase validacion
        Validacion v = new Validacion();


        public FormAseguradora()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAseguradora_Load(object sender, EventArgs e)
        {
            Llenar_DataGridView();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void txtAseguradora_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Llenar_DataGridView()
        {
            //Los argumentos de conexion a la base de datos
            string args = "Data Source=.;Initial Catalog=Consultas;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = args;

            try
            {
                //Indico el SP que voy a utilizar
                SqlCommand command = new SqlCommand("SELECCIONAR_DATOS_ASEGURADORA", conn);
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

        private void button8_Click(object sender, EventArgs e)
        {
            Llenar_DataGridView();
            ASEGURADORA_MEDICA_AGREGAR_MODIFICAR();
        }

        public void ASEGURADORA_MEDICA_AGREGAR_MODIFICAR()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("ASEGURADORA_MEDICA_AGREGAR_MODIFICAR", con))
            {
                string Aseguradora_id = "";
                if (txtID.Text == "")
                    Aseguradora_id = "0";
                else
                    Aseguradora_id = txtID.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_ASEGURADORA", SqlDbType.Int).Value = Aseguradora_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtAseguradora.Text;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = txtDescripcion.Text;
                cmd.Parameters.Add("@DIRECCION", SqlDbType.NVarChar).Value = txtDireccion.Text;
                cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkEstado.Checked;


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox2);
        }

        ///////////////////////////////////////
        public void seleccion_data_aseguradora()
        {
            try
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAseguradora.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                checkEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            seleccion_data_aseguradora();
        }
    }
}
