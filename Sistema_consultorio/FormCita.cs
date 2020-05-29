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
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Consultas;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand("[CITA_AGREGAR_MODIFICAR]", con))
            {
                string CITA_ID = "";
                if (txtID.Text == "")
                    CITA_ID = "0";
                else
                    CITA_ID = txtID.Text;
                //Mayuscula(); crear el metood para mayusculas

               


               
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }

        /// //////////////////////////////////////////////////////////////








    }
}
