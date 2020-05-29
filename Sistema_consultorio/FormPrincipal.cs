using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        
        }


        #region Funcionalidades del formulario

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);


            ////////lineas diagonales que aparecen en el grip inferior al momento de arrastrar
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Capturar posicion y tamano antes de maximizar para restaurar
        int lx, ly;  //l = location
        int sw, sh;  // s = size
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X; //lx sera igual a la localicaion en eje x del formulario
            ly = this.Location.Y; //ly sera igual a la localicaion en eje y del formulario
            sw = this.Size.Width; // sw sera igual al ancho actual del formulario
            sh = this.Size.Height; // sh sera igual al alto actual del formulario
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// //////////////////////////  /////////////////////////////////////////////////////  
        // este metodo sirve para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormPaciente>(); //llamamos el metood para abrir el formulario
            button1.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCita>(); //llamamos el metood para abrir el formulario
            button2.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormConsulta>(); //llamamos el metood para abrir el formulario
            btnConsultas.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormConfiguracion>(); //llamamos el metood para abrir el formulario
            btnConfiguracion.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMedico>(); //llamamos el metood para abrir el formulario
            btnMedicos.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormLogin login1 = new FormLogin();
            login1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSecretaria secretaria = new FormSecretaria();
            secretaria.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FormSecretaria>(); //llamamos el metood para abrir el formulario
            btnSecretaria.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario<FormMuestrasMedidas>(); //llamamos el metood para abrir el formulario
            btnMuestrasMedicas.BackColor = Color.FromArgb(12, 61, 92); // para cambiar el color del boton cuando este clicked
        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion
        // Metodo para abrir formularios dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // Busca en la coleccion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;     //Para eliminar los bordes del formulario
                formulario.Dock = DockStyle.Fill;            // para que el formulario se acople al panel
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms); // este es el metodo creado para que el botnon regrese a su color oriinal luego de haber berrado el formulario

            }

            // si el formulari/instancia existe simplemente lo traemos al frente
            else
            {
                formulario.BringToFront();
            }

        }
            //metodo para que el boton regrese a su color original luego de estar en estado cliked y haber cerrado
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormPaciente"] == null)       // para especificar el nombre del formulario 
                button1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormCita"] == null)       // para especificar el nombre del formulario
                button2.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormConsulta"] == null)      // para especificar el nombre del formulario
                btnConsultas.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormConfiguracion"] == null)      // para especificar el nombre del formulario
                btnConfiguracion.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormMedico"] == null)      // para especificar el nombre del formulario
                btnMedicos.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormSecretaria"] == null)      // para especificar el nombre del formulario
                btnSecretaria.BackColor = Color.FromArgb(4, 41, 68);




        }

    }
}
