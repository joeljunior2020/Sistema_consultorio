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
        public FormMedico()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {

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
            SqlConnection con = new SqlConnection();
            using (SqlCommand cmd = new SqlCommand("DOCTOR_AGREGAR_MODIFICAR", con))
            {
                string Doctor_id = "";
                if (txtID.Text == "")
                    Doctor_id = "0";
                else
                    Doctor_id = txtID.Text;
                //Mayuscula(); crear el metood para mayusculas

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_DOCTOR", SqlDbType.Int).Value = txtID.Text;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = txtApellido.Text;
                cmd.Parameters.Add("@CEDULA", SqlDbType.NVarChar).Value = txtCedula.Text;
                cmd.Parameters.Add("@SEXO ", SqlDbType.Char).Value = cmbSexo.Text;
                cmd.Parameters.Add("@EMAIL ", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO ", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                cmd.Parameters.Add("@ID_ESPECIALIDAD ", SqlDbType.Int).Value = cboEspecialidad.Text;


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
