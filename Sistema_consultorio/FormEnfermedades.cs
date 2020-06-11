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
    public partial class FormEnfermedades : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();

        public FormEnfermedades()
        {
            InitializeComponent();
        }

        private void FormEnfermedades_Load(object sender, EventArgs e)
        {
            ///crando instancia de la clase validacion
            Validacion v = new Validacion();

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void txtEnfermedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e); //validar que solo se escriba letras en el textbox
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void guardar_modificar_enfermedades()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("ENFERMEDADES_AGREGAR_MODIFICAR", con))
            {
                string enfermedades_id = "";
                if (txtID.Text == "")
                    enfermedades_id = "0";
                else
                    enfermedades_id = txtID.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = enfermedades_id;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtEnfermedad.Text;
                cmd.Parameters.Add("@TIPO_ENFERMEDAD", SqlDbType.NVarChar).Value = cboTipoEnfermedad.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@ESTADO ", SqlDbType.Bit).Value = checkEstado.Checked;
            

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            guardar_modificar_enfermedades();
        }
    }
}
