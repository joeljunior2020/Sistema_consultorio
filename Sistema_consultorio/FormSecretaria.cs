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
    public partial class FormSecretaria : Form
    {
        public FormSecretaria()
        {
            InitializeComponent();
        }

        private void FormSecretaria_Load(object sender, EventArgs e)
        {

        }

        /// //////////////////////////////////////////////////////////////


        public void SECRETARIA_AGREGAR_MODIFICAR()
        {
            SqlConnection con = new SqlConnection();
            using (SqlCommand cmd = new SqlCommand("SECRETARIA_AGREGAR_MODIFICAR", con))
            {
                string Secretaria_id = "";
                if (txtID.Text == "")
                    Secretaria_id = "0";
                else
                    Secretaria_id = txtID.Text;
                //Mayuscula(); crear el metood para mayusculas

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_SECRETARIA", SqlDbType.Int).Value = txtID.Text;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("@DIRECCION ", SqlDbType.NVarChar).Value = txtDireccion.Text;

                cmd.Parameters.Add("@EMAIL ", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@CEDULA", SqlDbType.NVarChar).Value = txtCedula.Text;
                cmd.Parameters.Add("@SEXO ", SqlDbType.Char).Value = cmbSexo.Text;
         
                cmd.Parameters.Add("@FECHA_REGISTRO ", SqlDbType.DateTime).Value = dateTimePicker1.Text;



                /*
                agregar parametros de entrada para el ID_LICENCIA
                agregar parametros de entrada para el ID_USUARIO
                */
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }

        /// //////////////////////////////////////////////////////////////



    }
}
