using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{


    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }


        Conexion con = new Conexion();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            guardar_pasiente();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
          
        }

        public void guardar_pasiente()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Consultas;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand("PACIENTE_AGREGAR_MODIFICAR",con))
            {
                string paciente_id = "";
                if (txtID.Text == "")
                    paciente_id = "0";
                else
                    paciente_id = txtID.Text;
             //////   Mayuscula(); crear el metodo para mayusculas

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = txtID.Text;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@APELLIDO", SqlDbType.NVarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("@CEDULA", SqlDbType.NVarChar).Value = txtCedula.Text;
                cmd.Parameters.Add("@SEGURO", SqlDbType.NVarChar).Value = txtSeguro.Text;
                cmd.Parameters.Add("@FECHA_NACIMIENTO ", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@SEXO ", SqlDbType.Char).Value = cboSexo.Text;
                cmd.Parameters.Add("@DIRECCION ", SqlDbType.NVarChar).Value = txtDireccion.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = dtpFecha_Registro.Value;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkEstado.Text;
                cmd.Parameters.Add("ID_LICENCIA", SqlDbType.Int).Value = txtIDLicencia.Text;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = txtIDUsuario.Text;

     
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }
     







    }
}
