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
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();
        }

       Conexion con = new Conexion();
       

       
        private void FormLogin_Load(object sender, EventArgs e)
        {
          con.Conectar();
          
            txtUsuario.Focus();
   
           
        }
      
        #region apariencia



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void btnPrueba_Click(object sender, EventArgs e)
        {
            FormPrincipal frmprinciapl = new FormPrincipal();
            frmprinciapl.Show();
        }


        #endregion
        /*-------------------------------------------------*/


        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string usuario = txtUsuario.Text;
 
            {
                if (e.KeyChar == (char)13)
                {
                    txtContrasena.Focus();
                }

            }
          
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string contrasena = txtContrasena.Text;
                txtLicencia.Focus();
                txtContrasena.Text = contrasena;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormPrincipal menu = new FormPrincipal();
            menu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Validar_login();
            
        
        }

     

        public int Validar_login()
        {


            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Consultas;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand("VALIDAR_LOGIN",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.NVarChar).Value = txtContrasena.Text;
                cmd.Parameters.Add("@ID_LICENCIA", SqlDbType.Int).Value = txtLicencia.Text;

                

                    SqlParameter paramentro = new SqlParameter("@resultado", SqlDbType.Int);
                    paramentro.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(paramentro);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int nf = 0;
                    nf = ((int)cmd.Parameters["@resultado"].Value);
           
                //////////////////////////parametros de prueba///////////////////////////////////////
                //    SqlParameter paramentro2 = new SqlParameter("@ID_USUARIO", SqlDbType.Int);
                //    paramentro2.Direction = ParameterDirection.ReturnValue;
                //    cmd.Parameters.Add(paramentro2);
                //    cmd.ExecuteNonQuery();
                //    int idUsuario = 0;
                //    idUsuario = ((int)cmd.Parameters["@ID_USUARIO"].Value);


                //SqlParameter paramentro3 = new SqlParameter("@PUESTO", SqlDbType.Int);
                //paramentro3.Direction = ParameterDirection.ReturnValue;
                //cmd.Parameters.Add(paramentro3);
                //cmd.ExecuteNonQuery();
                //int puesto = 0;
                //puesto = ((int)cmd.Parameters["@PUESTO"].Value);
                //////////////////////////////////////////////////////////


                int resultado = nf;
                if (resultado == 0)
                {
                    MessageBox.Show("ERROR");
                }
                else if (resultado == 1)  /*si la licencia y credenciales son validas*/
                {
                    //  MessageBox.Show("Bienvenido: "+txtUsuario.Text+ "SU id es: " +idUsuario+ "Su puesto " +puesto); //para probar todos los parametros de reorno
                    MessageBox.Show("Bienvenido: " + txtUsuario.Text);
                    FormPrincipal menu = new FormPrincipal();
                    menu.id_licencia.Text = txtLicencia.Text;
                    menu.NombreUsuario.Text = txtUsuario.Text; 
                    menu.Show();



                }
                else if (resultado == -1)    /*LIcencia vencida*/
                {
                    MessageBox.Show("Su licencia a vencido" );
                }
                else         /*Error credenciales*/
                {
                    MessageBox.Show("Vuelva a introducir sus credenciales");
                }


                ///////////////////////

                con.Close();
                    return nf;
                    
                    


            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validar_login();
        }
    }





}
