using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_consultorio
{


    public partial class FormCita : Form
    {
        Validacion v = new Validacion();


        public FormCita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this, groupBox2);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormCita_Load(object sender, EventArgs e)
        {

        }

        /// //////////////////////////////////////////////////////////////


        public void CITA_AGREGAR_MODIFICAR()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("[CITA_AGREGAR_MODIFICAR]", con))
            {
                string CITA_ID = "";
                if (txtID.Text == "")
                    CITA_ID = "0";
                else
                    CITA_ID = txtID.Text;
                //Mayuscula(); crear el metood para mayusculas

                DateTime today = DateTime.Today; // optenr la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_CITA", SqlDbType.Int).Value = CITA_ID;
                cmd.Parameters.Add("@PACIENTE", SqlDbType.NVarChar).Value = txtPaciente.Text;
                cmd.Parameters.Add("@FECHA_CITA ", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                cmd.Parameters.Add("@HORARIO ", SqlDbType.VarChar).Value = cboHorario.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@OBSERVACIONES", SqlDbType.NVarChar).Value = txtPaciente.Text;
                cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value  = txtIdPaciente.Text  ;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;





                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            CITA_AGREGAR_MODIFICAR();
        }

        /// //////////////////////////////////////////////////////////////








    }
}
