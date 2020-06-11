namespace Sistema_consultorio
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.USUARIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_USUARIO = new System.Windows.Forms.TextBox();
            this.txt_CONTRASENA = new System.Windows.Forms.TextBox();
            this.txt_LICENCIA = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.BackColor = System.Drawing.Color.LightGray;
            this.USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.Location = new System.Drawing.Point(462, 192);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(82, 18);
            this.USUARIO.TabIndex = 0;
            this.USUARIO.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 189;
            this.label1.Text = "CONTRASENA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 190;
            this.label2.Text = "CLAVE DE LICENCIA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Sistema_consultorio.Properties.Resources.cancel_77947;
            this.button1.Location = new System.Drawing.Point(884, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 179;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_consultorio.Properties.Resources.plantillasLogin1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(964, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_USUARIO
            // 
            this.txt_USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_USUARIO.Location = new System.Drawing.Point(581, 181);
            this.txt_USUARIO.Multiline = true;
            this.txt_USUARIO.Name = "txt_USUARIO";
            this.txt_USUARIO.Size = new System.Drawing.Size(224, 37);
            this.txt_USUARIO.TabIndex = 0;
            this.txt_USUARIO.Text = "pedro";
            this.txt_USUARIO.TextChanged += new System.EventHandler(this.txtPrueba1_TextChanged);
            this.txt_USUARIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrueba1_KeyPress);
            // 
            // txt_CONTRASENA
            // 
            this.txt_CONTRASENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CONTRASENA.Location = new System.Drawing.Point(581, 284);
            this.txt_CONTRASENA.Multiline = true;
            this.txt_CONTRASENA.Name = "txt_CONTRASENA";
            this.txt_CONTRASENA.PasswordChar = '*';
            this.txt_CONTRASENA.Size = new System.Drawing.Size(224, 37);
            this.txt_CONTRASENA.TabIndex = 1;
            this.txt_CONTRASENA.Text = "pablo";
            this.txt_CONTRASENA.TextChanged += new System.EventHandler(this.txt_CONTRASENA_TextChanged);
            this.txt_CONTRASENA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CONTRASENA_KeyPress);
            // 
            // txt_LICENCIA
            // 
            this.txt_LICENCIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LICENCIA.Location = new System.Drawing.Point(581, 382);
            this.txt_LICENCIA.Multiline = true;
            this.txt_LICENCIA.Name = "txt_LICENCIA";
            this.txt_LICENCIA.PasswordChar = '*';
            this.txt_LICENCIA.Size = new System.Drawing.Size(224, 37);
            this.txt_LICENCIA.TabIndex = 2;
            this.txt_LICENCIA.Text = "1";
            this.txt_LICENCIA.TextChanged += new System.EventHandler(this.txt_LICENCIA_TextChanged);
            this.txt_LICENCIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LICENCIA_KeyPress);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(127, 505);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(87, 20);
            this.txtPuesto.TabIndex = 202;
            this.txtPuesto.Visible = false;
            this.txtPuesto.TextChanged += new System.EventHandler(this.txtPuesto_TextChanged);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(127, 531);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(87, 20);
            this.txtIdUsuario.TabIndex = 203;
            this.txtIdUsuario.Visible = false;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.txtIdUsuario_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(182)))), ((int)(((byte)(70)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(18, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 68);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(497, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 85);
            this.panel1.TabIndex = 3;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txt_LICENCIA);
            this.Controls.Add(this.txt_CONTRASENA);
            this.Controls.Add(this.txt_USUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_USUARIO;
        private System.Windows.Forms.TextBox txt_CONTRASENA;
        private System.Windows.Forms.TextBox txt_LICENCIA;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
    }
}