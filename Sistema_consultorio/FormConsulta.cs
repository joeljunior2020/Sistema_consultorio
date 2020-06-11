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
    public partial class FormConsulta : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();


        public FormConsulta()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMoticoConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBuscarPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRECETA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNOmbre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNOmbre_KeyPress(object sender, KeyPressEventArgs e)
        {

            v.sololetras(e); //validar que solo se escriba letras en el textbox

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void txtBuscarCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        public void guardar_modificar_CONSULTA()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("[CONSULTA_AGREGAR_MODIFICAR]", con))
            {
                string Consulta_id = "";
                if (txtIDConsulta.Text == "")
                    Consulta_id = "0";
                else
                    Consulta_id = txtIDConsulta.Text;
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_CONSULTA", SqlDbType.Int).Value = Consulta_id;
                cmd.Parameters.Add("@MOTIVO", SqlDbType.NVarChar).Value = txtMoticoConsulta.Text;
                cmd.Parameters.Add("@EXPLORACION_FISICA", SqlDbType.NVarChar).Value = txtExploracionConsulta.Text;
                cmd.Parameters.Add("@SINTOMA_SUJETIVO", SqlDbType.NVarChar).Value = txtSintomasSubjetivos.Text;
                cmd.Parameters.Add("@DIAGNOSTICO", SqlDbType.NVarChar).Value = txtDiagnostico.Text;
                cmd.Parameters.Add("@TRATAMIENTO", SqlDbType.NVarChar).Value = txtTratamiento.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@PRECIO", SqlDbType.Float).Value = txtPrecio.Text;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Bit).Value = checkEstado.Checked;
                //   cmd.Parameters.Add("@ID_POLIZA_SEGURO", SqlDbType.Int).Value = ;
                cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = txtID_Paciente.Text;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }


        }

        public void guardar_Historial_clinico()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("HISTORIAL_CLINICO_AGREGAR_MODIFICAR", con))
            {
            
                  int   Historila_ID = 0;
             
                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_HISTORIAL_CLINICO", SqlDbType.Int).Value = Historila_ID;
                cmd.Parameters.Add("@ALERGIAS", SqlDbType.NVarChar).Value = txtAlergias.Text;
                cmd.Parameters.Add("@ANTECENDENTE_CRONICO", SqlDbType.NVarChar).Value = txtAnteCronicos.Text;
                cmd.Parameters.Add("@ANTECEDENTE_QUIRURGICO", SqlDbType.NVarChar).Value = txtAnteQuirurgicos.Text;
                cmd.Parameters.Add("@ANTECEDENTE_FAMILIARE", SqlDbType.NVarChar).Value = txtAnteFamiliares.Text;
                cmd.Parameters.Add("@OTROS", SqlDbType.NVarChar).Value = txtOtros.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@ID_PACIENTE", SqlDbType.Int).Value = txtID_Paciente.Text;
                cmd.Parameters.Add("@ID_ENFERMEDAD", SqlDbType.Int).Value = cboEnfermedad.Text;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;
                


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

        private void btnGuardarHistorial_Click_1(object sender, EventArgs e)
        {
            guardar_Historial_clinico();
        }

        public void RECETA_AGREGAR_MODIFICAR()
        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("RECETA_AGREGAR_MODIFICAR", con))
            {
                int receta_id = 0;
           

                //////   Mayuscula(); crear el metodo para mayusculas

                DateTime today = DateTime.Today; // optener la fecha actual

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_MUESTRA_MEDICA", SqlDbType.Int).Value = receta_id;
                cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@MEDICAMENTO", SqlDbType.NVarChar).Value = txtMedicamento.Text;
                cmd.Parameters.Add("@CONSENTRACION", SqlDbType.NVarChar).Value = txtConcentracion.Text;
                cmd.Parameters.Add("@TOMAR", SqlDbType.NVarChar).Value = txtTomar.Text;
                cmd.Parameters.Add("@DURANTE", SqlDbType.NVarChar).Value = txtDuracion.Text;
                cmd.Parameters.Add("@FRECUENCIA", SqlDbType.NVarChar).Value = txtFrecuencia.Text;
                cmd.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value = today;
                cmd.Parameters.Add("@ID_CONSULTA", SqlDbType.Int).Value = txtIDConsulta.Text;
                cmd.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = DatosGlobales.ID_USUARIO_GLOBAL;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }

      
    }

      
    }
