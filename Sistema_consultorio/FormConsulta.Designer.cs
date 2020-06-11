namespace Sistema_consultorio
{
    partial class FormConsulta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtSintomasSubjetivos = new System.Windows.Forms.TextBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtExploracionConsulta = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoticoConsulta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRECETA = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCENTRACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOMAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRECUENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.txtTomar = new System.Windows.Forms.TextBox();
            this.txtConcentracion = new System.Windows.Forms.TextBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.cboEnfermedad = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAnteQuirurgicos = new System.Windows.Forms.TextBox();
            this.txtAnteFamiliares = new System.Windows.Forms.TextBox();
            this.txtAnteCronicos = new System.Windows.Forms.TextBox();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnGuardarHistorial = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnImprimirEstudios = new System.Windows.Forms.Button();
            this.txtSolicitudEstudios = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDConsulta = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.dgvBuscarPaciente = new System.Windows.Forms.DataGridView();
            this.txtID_Paciente = new System.Windows.Forms.TextBox();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNOmbre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHistorialConsultas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTerminarConsulta = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRECETA)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 263);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 365);
            this.tabControl1.TabIndex = 118;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.txtSintomasSubjetivos);
            this.tabPage1.Controls.Add(this.txtTratamiento);
            this.tabPage1.Controls.Add(this.txtExploracionConsulta);
            this.tabPage1.Controls.Add(this.txtDiagnostico);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtMoticoConsulta);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta Médica ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtEstatura);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPeso);
            this.groupBox3.Location = new System.Drawing.Point(13, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 287);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Estatua";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(9, 115);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(100, 20);
            this.txtEstatura.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(9, 47);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 29;
            // 
            // txtSintomasSubjetivos
            // 
            this.txtSintomasSubjetivos.Location = new System.Drawing.Point(800, 42);
            this.txtSintomasSubjetivos.Multiline = true;
            this.txtSintomasSubjetivos.Name = "txtSintomasSubjetivos";
            this.txtSintomasSubjetivos.Size = new System.Drawing.Size(273, 121);
            this.txtSintomasSubjetivos.TabIndex = 28;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(494, 200);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(579, 121);
            this.txtTratamiento.TabIndex = 27;
            // 
            // txtExploracionConsulta
            // 
            this.txtExploracionConsulta.Location = new System.Drawing.Point(494, 42);
            this.txtExploracionConsulta.Multiline = true;
            this.txtExploracionConsulta.Name = "txtExploracionConsulta";
            this.txtExploracionConsulta.Size = new System.Drawing.Size(273, 121);
            this.txtExploracionConsulta.TabIndex = 26;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(195, 200);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(273, 121);
            this.txtDiagnostico.TabIndex = 25;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(491, 174);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 13);
            this.label32.TabIndex = 21;
            this.label32.Text = "Tratamiento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Diagnóstico ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(797, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Síntomas Subjetivos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(491, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Exploración Física";
            // 
            // txtMoticoConsulta
            // 
            this.txtMoticoConsulta.Location = new System.Drawing.Point(195, 42);
            this.txtMoticoConsulta.Multiline = true;
            this.txtMoticoConsulta.Name = "txtMoticoConsulta";
            this.txtMoticoConsulta.Size = new System.Drawing.Size(273, 121);
            this.txtMoticoConsulta.TabIndex = 10;
            this.txtMoticoConsulta.TextChanged += new System.EventHandler(this.txtMoticoConsulta_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Motivo de Consulta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNuevaCita);
            this.tabPage2.Controls.Add(this.btnImprimir);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvRECETA);
            this.tabPage2.Controls.Add(this.txtDuracion);
            this.tabPage2.Controls.Add(this.txtFrecuencia);
            this.tabPage2.Controls.Add(this.txtTomar);
            this.tabPage2.Controls.Add(this.txtConcentracion);
            this.tabPage2.Controls.Add(this.txtMedicamento);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recetas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Image = global::Sistema_consultorio.Properties.Resources._1486564412_plus_81511;
            this.btnNuevaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.Location = new System.Drawing.Point(835, 92);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(180, 44);
            this.btnNuevaCita.TabIndex = 198;
            this.btnNuevaCita.Text = "AGREGAR";
            this.btnNuevaCita.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Sistema_consultorio.Properties.Resources.ImprmirICONO;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(835, 183);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(180, 45);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Imprimir ";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(678, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Duracion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(549, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Frecuencia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tomar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Concentracion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Medicamento:";
            // 
            // dgvRECETA
            // 
            this.dgvRECETA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRECETA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRECETA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.MEDICAMENTO,
            this.CONCENTRACION,
            this.TOMAR,
            this.FRECUENCIA,
            this.DURACION});
            this.dgvRECETA.Location = new System.Drawing.Point(18, 92);
            this.dgvRECETA.Name = "dgvRECETA";
            this.dgvRECETA.Size = new System.Drawing.Size(769, 227);
            this.dgvRECETA.TabIndex = 17;
            this.dgvRECETA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRECETA_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.Width = 50;
            // 
            // MEDICAMENTO
            // 
            this.MEDICAMENTO.HeaderText = "MEDICAMENTO";
            this.MEDICAMENTO.Name = "MEDICAMENTO";
            this.MEDICAMENTO.Width = 200;
            // 
            // CONCENTRACION
            // 
            this.CONCENTRACION.HeaderText = "CONCENTRACION";
            this.CONCENTRACION.Name = "CONCENTRACION";
            this.CONCENTRACION.Width = 120;
            // 
            // TOMAR
            // 
            this.TOMAR.HeaderText = "TOMAR";
            this.TOMAR.Name = "TOMAR";
            this.TOMAR.Width = 120;
            // 
            // FRECUENCIA
            // 
            this.FRECUENCIA.HeaderText = "FRECUENCIA";
            this.FRECUENCIA.Name = "FRECUENCIA";
            this.FRECUENCIA.Width = 120;
            // 
            // DURACION
            // 
            this.DURACION.HeaderText = "DURACION";
            this.DURACION.Name = "DURACION";
            this.DURACION.Width = 120;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(681, 58);
            this.txtDuracion.Multiline = true;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(118, 27);
            this.txtDuracion.TabIndex = 15;
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(552, 59);
            this.txtFrecuencia.Multiline = true;
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.Size = new System.Drawing.Size(118, 27);
            this.txtFrecuencia.TabIndex = 14;
            // 
            // txtTomar
            // 
            this.txtTomar.Location = new System.Drawing.Point(417, 58);
            this.txtTomar.Multiline = true;
            this.txtTomar.Name = "txtTomar";
            this.txtTomar.Size = new System.Drawing.Size(118, 27);
            this.txtTomar.TabIndex = 13;
            // 
            // txtConcentracion
            // 
            this.txtConcentracion.Location = new System.Drawing.Point(239, 58);
            this.txtConcentracion.Multiline = true;
            this.txtConcentracion.Name = "txtConcentracion";
            this.txtConcentracion.Size = new System.Drawing.Size(155, 27);
            this.txtConcentracion.TabIndex = 12;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(18, 58);
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(198, 27);
            this.txtMedicamento.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 20);
            this.label19.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 24);
            this.label18.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtOtros);
            this.tabPage3.Controls.Add(this.cboEnfermedad);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.txtAnteQuirurgicos);
            this.tabPage3.Controls.Add(this.txtAnteFamiliares);
            this.tabPage3.Controls.Add(this.txtAnteCronicos);
            this.tabPage3.Controls.Add(this.btnVerHistorial);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.txtAlergias);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.btnGuardarHistorial);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1102, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historia  Clínica ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(12, 199);
            this.txtOtros.Multiline = true;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(323, 71);
            this.txtOtros.TabIndex = 203;
            // 
            // cboEnfermedad
            // 
            this.cboEnfermedad.FormattingEnabled = true;
            this.cboEnfermedad.Location = new System.Drawing.Point(731, 200);
            this.cboEnfermedad.Name = "cboEnfermedad";
            this.cboEnfermedad.Size = new System.Drawing.Size(323, 21);
            this.cboEnfermedad.TabIndex = 202;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(13, 176);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(286, 20);
            this.label29.TabIndex = 202;
            this.label29.Text = "Otros (medicamentos, traumatismos...):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(732, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 20);
            this.label21.TabIndex = 201;
            this.label21.Text = "Enfermedades";
            // 
            // txtAnteQuirurgicos
            // 
            this.txtAnteQuirurgicos.Location = new System.Drawing.Point(731, 66);
            this.txtAnteQuirurgicos.Multiline = true;
            this.txtAnteQuirurgicos.Name = "txtAnteQuirurgicos";
            this.txtAnteQuirurgicos.Size = new System.Drawing.Size(323, 71);
            this.txtAnteQuirurgicos.TabIndex = 200;
            // 
            // txtAnteFamiliares
            // 
            this.txtAnteFamiliares.Location = new System.Drawing.Point(374, 199);
            this.txtAnteFamiliares.Multiline = true;
            this.txtAnteFamiliares.Name = "txtAnteFamiliares";
            this.txtAnteFamiliares.Size = new System.Drawing.Size(323, 71);
            this.txtAnteFamiliares.TabIndex = 199;
            // 
            // txtAnteCronicos
            // 
            this.txtAnteCronicos.Location = new System.Drawing.Point(374, 66);
            this.txtAnteCronicos.Multiline = true;
            this.txtAnteCronicos.Name = "txtAnteCronicos";
            this.txtAnteCronicos.Size = new System.Drawing.Size(323, 71);
            this.txtAnteCronicos.TabIndex = 198;
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Image = global::Sistema_consultorio.Properties.Resources.CITAS__2_;
            this.btnVerHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerHistorial.Location = new System.Drawing.Point(353, 292);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(206, 44);
            this.btnVerHistorial.TabIndex = 30;
            this.btnVerHistorial.Text = "Historial Clínico";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(370, 176);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(189, 20);
            this.label30.TabIndex = 34;
            this.label30.Text = "Antecedentes Familiares:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(10, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(310, 25);
            this.label25.TabIndex = 6;
            this.label25.Text = "Historia Clinica del Paciente";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(370, 43);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(179, 20);
            this.label31.TabIndex = 33;
            this.label31.Text = "Antecedentes Crónicos:";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(17, 66);
            this.txtAlergias.Multiline = true;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(323, 71);
            this.txtAlergias.TabIndex = 35;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(18, 43);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 20);
            this.label28.TabIndex = 32;
            this.label28.Text = "Alergias:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(726, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(197, 20);
            this.label27.TabIndex = 33;
            this.label27.Text = "Antecedentes Quirúrgicos:";
            // 
            // btnGuardarHistorial
            // 
            this.btnGuardarHistorial.Image = global::Sistema_consultorio.Properties.Resources.yucata2;
            this.btnGuardarHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarHistorial.Location = new System.Drawing.Point(598, 292);
            this.btnGuardarHistorial.Name = "btnGuardarHistorial";
            this.btnGuardarHistorial.Size = new System.Drawing.Size(206, 44);
            this.btnGuardarHistorial.TabIndex = 196;
            this.btnGuardarHistorial.Text = "GUARDAR HISTORIAL";
            this.btnGuardarHistorial.UseVisualStyleBackColor = true;
            this.btnGuardarHistorial.Click += new System.EventHandler(this.btnGuardarHistorial_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnImprimirEstudios);
            this.tabPage4.Controls.Add(this.txtSolicitudEstudios);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1102, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Exámenes/Estudios";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnImprimirEstudios
            // 
            this.btnImprimirEstudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirEstudios.Location = new System.Drawing.Point(93, 277);
            this.btnImprimirEstudios.Name = "btnImprimirEstudios";
            this.btnImprimirEstudios.Size = new System.Drawing.Size(191, 48);
            this.btnImprimirEstudios.TabIndex = 13;
            this.btnImprimirEstudios.Text = "Imprimir Solicitud";
            this.btnImprimirEstudios.UseVisualStyleBackColor = true;
            // 
            // txtSolicitudEstudios
            // 
            this.txtSolicitudEstudios.Location = new System.Drawing.Point(93, 75);
            this.txtSolicitudEstudios.Multiline = true;
            this.txtSolicitudEstudios.Name = "txtSolicitudEstudios";
            this.txtSolicitudEstudios.Size = new System.Drawing.Size(738, 196);
            this.txtSolicitudEstudios.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(338, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(240, 20);
            this.label24.TabIndex = 11;
            this.label24.Text = "Solicitud de Estudios/Exámenes ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDConsulta);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkEstado);
            this.groupBox1.Controls.Add(this.dgvBuscarPaciente);
            this.groupBox1.Controls.Add(this.txtID_Paciente);
            this.groupBox1.Controls.Add(this.txtBuscarCedula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNOmbre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 194);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PACIENTE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.Location = new System.Drawing.Point(101, 38);
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.Size = new System.Drawing.Size(89, 20);
            this.txtIDConsulta.TabIndex = 199;
            this.txtIDConsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 16);
            this.label20.TabIndex = 198;
            this.label20.Text = "ID Consulta";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 197;
            this.label1.Text = "Estado:";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(101, 165);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(15, 14);
            this.checkEstado.TabIndex = 196;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvBuscarPaciente
            // 
            this.dgvBuscarPaciente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarPaciente.Location = new System.Drawing.Point(327, 52);
            this.dgvBuscarPaciente.Name = "dgvBuscarPaciente";
            this.dgvBuscarPaciente.ReadOnly = true;
            this.dgvBuscarPaciente.Size = new System.Drawing.Size(733, 136);
            this.dgvBuscarPaciente.TabIndex = 196;
            // 
            // txtID_Paciente
            // 
            this.txtID_Paciente.Location = new System.Drawing.Point(101, 64);
            this.txtID_Paciente.Name = "txtID_Paciente";
            this.txtID_Paciente.Size = new System.Drawing.Size(89, 20);
            this.txtID_Paciente.TabIndex = 29;
            this.txtID_Paciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.Location = new System.Drawing.Point(101, 123);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(154, 20);
            this.txtBuscarCedula.TabIndex = 124;
            this.txtBuscarCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCedula_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "Cedula";
            // 
            // txtNOmbre
            // 
            this.txtNOmbre.Location = new System.Drawing.Point(101, 97);
            this.txtNOmbre.Name = "txtNOmbre";
            this.txtNOmbre.Size = new System.Drawing.Size(170, 20);
            this.txtNOmbre.TabIndex = 27;
            this.txtNOmbre.TextChanged += new System.EventHandler(this.txtNOmbre_TextChanged);
            this.txtNOmbre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOmbre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID Paciente";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(770, 24);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio.TabIndex = 25;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(665, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Valor a pagar:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 25);
            this.label16.TabIndex = 116;
            this.label16.Text = "Consulta Médica";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(874, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 119;
            // 
            // btnHistorialConsultas
            // 
            this.btnHistorialConsultas.Location = new System.Drawing.Point(668, 655);
            this.btnHistorialConsultas.Name = "btnHistorialConsultas";
            this.btnHistorialConsultas.Size = new System.Drawing.Size(175, 48);
            this.btnHistorialConsultas.TabIndex = 31;
            this.btnHistorialConsultas.Text = "Historial Consultas";
            this.btnHistorialConsultas.UseVisualStyleBackColor = true;
            this.btnHistorialConsultas.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_consultorio.Properties.Resources.cancel_77947;
            this.button1.Location = new System.Drawing.Point(1051, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 195;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTerminarConsulta
            // 
            this.btnTerminarConsulta.Image = global::Sistema_consultorio.Properties.Resources.yucata2;
            this.btnTerminarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminarConsulta.Location = new System.Drawing.Point(29, 634);
            this.btnTerminarConsulta.Name = "btnTerminarConsulta";
            this.btnTerminarConsulta.Size = new System.Drawing.Size(175, 48);
            this.btnTerminarConsulta.TabIndex = 193;
            this.btnTerminarConsulta.Text = "Terminar Consulta";
            this.btnTerminarConsulta.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1172, 838);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTerminarConsulta);
            this.Controls.Add(this.btnHistorialConsultas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormConsulta";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRECETA)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMoticoConsulta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCENTRACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOMAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRECUENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.TextBox txtTomar;
        private System.Windows.Forms.TextBox txtConcentracion;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnImprimirEstudios;
        private System.Windows.Forms.TextBox txtSolicitudEstudios;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID_Paciente;
        private System.Windows.Forms.TextBox txtNOmbre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSintomasSubjetivos;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtExploracionConsulta;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Button btnHistorialConsultas;
        private System.Windows.Forms.Button btnTerminarConsulta;
        private System.Windows.Forms.TextBox txtBuscarCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardarHistorial;
        private System.Windows.Forms.TextBox txtAnteQuirurgicos;
        private System.Windows.Forms.TextBox txtAnteFamiliares;
        private System.Windows.Forms.TextBox txtAnteCronicos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DataGridView dgvBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.TextBox txtIDConsulta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.ComboBox cboEnfermedad;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
    }
}