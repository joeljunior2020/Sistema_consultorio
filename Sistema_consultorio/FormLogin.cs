using Sistema_consultorio.ConsultasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    public partial class FormLogin : Form
    {
        ///crando instancia de la clase validacion
        Validacion v = new Validacion();


        public FormLogin()
        {
            InitializeComponent();
        }

       Conexion con = new Conexion();
       

       
        private void FormLogin_Load(object sender, EventArgs e)
        {
      

            //  txtUsuario.Focus();
           // MessageBox.Show(Sistema_consultorio.Clases.BD.conexxxion.ToString()); 
   
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Validar_login();
            //CARGAR_DATOS_USUARIO();


            //FormPrincipal menu = new FormPrincipal();
            //menu.LblNombre_Persona.Text = Nombre;
            //menu.txtIdUsuario_Menu.Text = txtIdUsuario.Text;
            //menu.lblTipo_Usuario.Text = Tipo_persona;
            //menu.lblLicencia.Text = txt_LICENCIA.Text;
            //menu.LblNombreUsuario.Text = txt_USUARIO.Text;
            //this.Hide();
            //menu.Show();

        }

        public int ID_LICENCIA;
        public string NOMBRE_USUARIO;

 


        #region Validar Login
        public int Validar_login()
        
        {


            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("VALIDAR_LOGIN", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txt_USUARIO.Text;
                cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.NVarChar).Value = txt_CONTRASENA.Text;
                cmd.Parameters.Add("@ID_LICENCIA", SqlDbType.Int).Value = txt_LICENCIA.Text;



                SqlParameter paramentro = new SqlParameter("@resultado", SqlDbType.Int);
                paramentro.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(paramentro);
                con.Open();
                cmd.ExecuteNonQuery();
                int nf = 0;
                nf = ((int)cmd.Parameters["@resultado"].Value);
                  MessageBox.Show(" Valor de retorno :" +nf);        /////////////////////////////PRUBEA DE RETORNO///////////////////////////////////////////////

                int resultado = nf;
                if (resultado == 0)
                {
                    MessageBox.Show("ERROR");
                }
                
                else if (resultado == -1)    /*LIcencia vencida*/
                {
                    MessageBox.Show("Su licencia a vencido");
                    txt_USUARIO.Text = "";
                    txt_CONTRASENA.Text = "";
                    txt_LICENCIA.Text = "";
                }
                else if (resultado == -2)       /*Error credenciales*/
                {
                    MessageBox.Show("Vuelva a introducir sus credenciales");
                    txt_USUARIO.Text = "";
                    txt_CONTRASENA.Text = "";
                    txt_LICENCIA.Text = "";
                }
                else //(resultado == 1)  /*si la licencia y credenciales son validas*/
                {

                    txtIdUsuario.Text = nf.ToString();
                    //SELECT_USUARIO();
                    CARGAR_DATOS_USUARIO();
                }
                con.Close();
                return nf;
                //MessageBox.Show("Bienvenido: " + txt_USUARIO.Text);
            }


        }
        #endregion



        public string Tipo_persona ="";
        public string Nombre = "";

        #region CARGAR DATOS USUARIO
        public void CARGAR_DATOS_USUARIO()

        {
            SqlConnection con = new SqlConnection(Clases.BD.conexxxion);
            using (SqlCommand cmd = new SqlCommand("CARGAR_DATOS_USUARIOS", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = txtIdUsuario.Text;
              

                SqlParameter paramentro = new SqlParameter("@ID_USUARIO", SqlDbType.Int);
                paramentro.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(paramentro);

                con.Open();
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Tipo_persona = reader.GetString(0);                 
                    Nombre = reader.GetString(1);

                }  

                con.Close();
                string ID_USER = txtIdUsuario.Text; ////////////////////////////////////////////PRUEBA
                MessageBox.Show("     TIPO :     " + Tipo_persona + "      ID_USUARIO :   " + ID_USER + "    NOMBRE :     " + Nombre);


                FormPrincipal menu = new FormPrincipal();
                menu.LblNombre_Persona.Text = Nombre;
                menu.txtIdUsuario_Menu.Text = txtIdUsuario.Text;
                menu.lblTipo_Usuario.Text = Tipo_persona;
                menu.lblLicencia.Text = txt_LICENCIA.Text;
                menu.LblNombreUsuario.Text = txt_USUARIO.Text;
                this.Hide();
                menu.Show();
                


            }




        }

        #endregion




        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPrueba1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtPrueba1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void txt_CONTRASENA_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_LICENCIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CONTRASENA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LICENCIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //validar que solo se escriba numeros en el textbox
        }

        private void txtPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

   
    }





}
