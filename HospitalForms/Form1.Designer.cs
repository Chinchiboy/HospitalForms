namespace HospitalForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMedico = new System.Windows.Forms.Button();
            this.buttonPaciente = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonVerMedico = new System.Windows.Forms.Button();
            this.buttonVerAdmin = new System.Windows.Forms.Button();
            this.buttonVerPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dniMedico = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.anyoIncorporacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.medicamentos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.ListBox();
            this.departamento = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.anadirMedico = new System.Windows.Forms.Button();
            this.groupBoxMedico = new System.Windows.Forms.GroupBox();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.anadirAdmin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nombreAdmin = new System.Windows.Forms.TextBox();
            this.sueldoAdmin = new System.Windows.Forms.TextBox();
            this.dniAdmin = new System.Windows.Forms.TextBox();
            this.apellidoAdmin = new System.Windows.Forms.TextBox();
            this.AnyoAdmin = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPaciente = new System.Windows.Forms.GroupBox();
            this.anadirPaciente = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nombrePaciente = new System.Windows.Forms.TextBox();
            this.dniPaciente = new System.Windows.Forms.TextBox();
            this.apellidoPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.planta = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxMedico.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.groupBoxPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMedico
            // 
            this.buttonMedico.Location = new System.Drawing.Point(33, 12);
            this.buttonMedico.Name = "buttonMedico";
            this.buttonMedico.Size = new System.Drawing.Size(87, 35);
            this.buttonMedico.TabIndex = 0;
            this.buttonMedico.Text = "Añadir Médico";
            this.buttonMedico.UseVisualStyleBackColor = true;
            this.buttonMedico.Click += new System.EventHandler(this.buttonMedico_Click);
            // 
            // buttonPaciente
            // 
            this.buttonPaciente.Location = new System.Drawing.Point(33, 98);
            this.buttonPaciente.Name = "buttonPaciente";
            this.buttonPaciente.Size = new System.Drawing.Size(87, 34);
            this.buttonPaciente.TabIndex = 1;
            this.buttonPaciente.Text = "Añadir Paciente";
            this.buttonPaciente.UseVisualStyleBackColor = true;
            this.buttonPaciente.Click += new System.EventHandler(this.buttonPaciente_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(33, 53);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(87, 39);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Añadir Administrativo";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonVerMedico
            // 
            this.buttonVerMedico.Location = new System.Drawing.Point(33, 138);
            this.buttonVerMedico.Name = "buttonVerMedico";
            this.buttonVerMedico.Size = new System.Drawing.Size(87, 33);
            this.buttonVerMedico.TabIndex = 3;
            this.buttonVerMedico.Text = "Ver Médico";
            this.buttonVerMedico.UseVisualStyleBackColor = true;
            this.buttonVerMedico.Click += new System.EventHandler(this.buttonVerMedico_Click);
            // 
            // buttonVerAdmin
            // 
            this.buttonVerAdmin.Location = new System.Drawing.Point(33, 177);
            this.buttonVerAdmin.Name = "buttonVerAdmin";
            this.buttonVerAdmin.Size = new System.Drawing.Size(87, 38);
            this.buttonVerAdmin.TabIndex = 4;
            this.buttonVerAdmin.Text = "Ver Administrativos";
            this.buttonVerAdmin.UseVisualStyleBackColor = true;
            this.buttonVerAdmin.Click += new System.EventHandler(this.buttonVerAdmin_Click);
            // 
            // buttonVerPaciente
            // 
            this.buttonVerPaciente.Location = new System.Drawing.Point(33, 221);
            this.buttonVerPaciente.Name = "buttonVerPaciente";
            this.buttonVerPaciente.Size = new System.Drawing.Size(87, 34);
            this.buttonVerPaciente.TabIndex = 5;
            this.buttonVerPaciente.Text = "Ver Paciente";
            this.buttonVerPaciente.UseVisualStyleBackColor = true;
            this.buttonVerPaciente.Click += new System.EventHandler(this.buttonVerPaciente_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sueldo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Año de incorporación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Especialidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(111, 18);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 1;
            // 
            // dniMedico
            // 
            this.dniMedico.Location = new System.Drawing.Point(111, 165);
            this.dniMedico.Name = "dniMedico";
            this.dniMedico.Size = new System.Drawing.Size(100, 20);
            this.dniMedico.TabIndex = 6;
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(111, 96);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(100, 20);
            this.sueldo.TabIndex = 4;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(111, 70);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 3;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(111, 44);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 2;
            // 
            // anyoIncorporacion
            // 
            this.anyoIncorporacion.Location = new System.Drawing.Point(111, 135);
            this.anyoIncorporacion.Name = "anyoIncorporacion";
            this.anyoIncorporacion.ShowCheckBox = true;
            this.anyoIncorporacion.Size = new System.Drawing.Size(230, 20);
            this.anyoIncorporacion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(269, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Medicamentos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // medicamentos
            // 
            this.medicamentos.FormattingEnabled = true;
            this.medicamentos.Items.AddRange(new object[] {
            "Paracetamol",
            "Ibuprofeno",
            "Omeprazol",
            "Amoxicilina",
            "Loratadina",
            "Metformina",
            "Diazepam"});
            this.medicamentos.Location = new System.Drawing.Point(356, 21);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.medicamentos.Size = new System.Drawing.Size(120, 95);
            this.medicamentos.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(23, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Fecha de alta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(111, 134);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ShowCheckBox = true;
            this.fechaAlta.Size = new System.Drawing.Size(239, 20);
            this.fechaAlta.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(32, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "DNI Médico";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // especialidad
            // 
            this.especialidad.FormattingEnabled = true;
            this.especialidad.Items.AddRange(new object[] {
            "Cardiologia,",
            "Pediatria,",
            "Neurologia,",
            "Oncologia,",
            "Oftalmologia,"});
            this.especialidad.Location = new System.Drawing.Point(111, 170);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(120, 95);
            this.especialidad.TabIndex = 6;
            // 
            // departamento
            // 
            this.departamento.FormattingEnabled = true;
            this.departamento.Items.AddRange(new object[] {
            "Administracion,",
            "RecursosHumanos,",
            "Finanzas,",
            "Marketing"});
            this.departamento.Location = new System.Drawing.Point(91, 170);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(120, 95);
            this.departamento.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 33;
            this.label12.Text = "Departamento";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // anadirMedico
            // 
            this.anadirMedico.Location = new System.Drawing.Point(289, 230);
            this.anadirMedico.Name = "anadirMedico";
            this.anadirMedico.Size = new System.Drawing.Size(87, 35);
            this.anadirMedico.TabIndex = 7;
            this.anadirMedico.Text = "Añadir";
            this.anadirMedico.UseVisualStyleBackColor = true;
            this.anadirMedico.Click += new System.EventHandler(this.anadirMedico_click);
            // 
            // groupBoxMedico
            // 
            this.groupBoxMedico.Controls.Add(this.label1);
            this.groupBoxMedico.Controls.Add(this.label2);
            this.groupBoxMedico.Controls.Add(this.label3);
            this.groupBoxMedico.Controls.Add(this.anadirMedico);
            this.groupBoxMedico.Controls.Add(this.label4);
            this.groupBoxMedico.Controls.Add(this.especialidad);
            this.groupBoxMedico.Controls.Add(this.label5);
            this.groupBoxMedico.Controls.Add(this.label6);
            this.groupBoxMedico.Controls.Add(this.nombre);
            this.groupBoxMedico.Controls.Add(this.sueldo);
            this.groupBoxMedico.Controls.Add(this.dni);
            this.groupBoxMedico.Controls.Add(this.apellido);
            this.groupBoxMedico.Controls.Add(this.anyoIncorporacion);
            this.groupBoxMedico.Location = new System.Drawing.Point(33, 276);
            this.groupBoxMedico.Name = "groupBoxMedico";
            this.groupBoxMedico.Size = new System.Drawing.Size(382, 279);
            this.groupBoxMedico.TabIndex = 36;
            this.groupBoxMedico.TabStop = false;
            this.groupBoxMedico.Text = "Añadir Médico";
            this.groupBoxMedico.Visible = false;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.anadirAdmin);
            this.groupBoxAdmin.Controls.Add(this.label11);
            this.groupBoxAdmin.Controls.Add(this.label13);
            this.groupBoxAdmin.Controls.Add(this.label14);
            this.groupBoxAdmin.Controls.Add(this.departamento);
            this.groupBoxAdmin.Controls.Add(this.label12);
            this.groupBoxAdmin.Controls.Add(this.label15);
            this.groupBoxAdmin.Controls.Add(this.label16);
            this.groupBoxAdmin.Controls.Add(this.nombreAdmin);
            this.groupBoxAdmin.Controls.Add(this.sueldoAdmin);
            this.groupBoxAdmin.Controls.Add(this.dniAdmin);
            this.groupBoxAdmin.Controls.Add(this.apellidoAdmin);
            this.groupBoxAdmin.Controls.Add(this.AnyoAdmin);
            this.groupBoxAdmin.Location = new System.Drawing.Point(33, 582);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(382, 279);
            this.groupBoxAdmin.TabIndex = 37;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Añadir Administrativo";
            this.groupBoxAdmin.Visible = false;
            // 
            // anadirAdmin
            // 
            this.anadirAdmin.Location = new System.Drawing.Point(289, 238);
            this.anadirAdmin.Name = "anadirAdmin";
            this.anadirAdmin.Size = new System.Drawing.Size(87, 35);
            this.anadirAdmin.TabIndex = 36;
            this.anadirAdmin.Text = "Añadir";
            this.anadirAdmin.UseVisualStyleBackColor = true;
            this.anadirAdmin.Click += new System.EventHandler(this.anadirAdmin_click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(43, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nombre";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(43, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Apellido";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(43, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "DNI";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(43, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Sueldo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(14, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 32);
            this.label16.TabIndex = 11;
            this.label16.Text = "Año de incorporación";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nombreAdmin
            // 
            this.nombreAdmin.Location = new System.Drawing.Point(111, 18);
            this.nombreAdmin.Name = "nombreAdmin";
            this.nombreAdmin.Size = new System.Drawing.Size(100, 20);
            this.nombreAdmin.TabIndex = 1;
            // 
            // sueldoAdmin
            // 
            this.sueldoAdmin.Location = new System.Drawing.Point(111, 96);
            this.sueldoAdmin.Name = "sueldoAdmin";
            this.sueldoAdmin.Size = new System.Drawing.Size(100, 20);
            this.sueldoAdmin.TabIndex = 4;
            // 
            // dniAdmin
            // 
            this.dniAdmin.Location = new System.Drawing.Point(111, 70);
            this.dniAdmin.Name = "dniAdmin";
            this.dniAdmin.Size = new System.Drawing.Size(100, 20);
            this.dniAdmin.TabIndex = 3;
            // 
            // apellidoAdmin
            // 
            this.apellidoAdmin.Location = new System.Drawing.Point(111, 44);
            this.apellidoAdmin.Name = "apellidoAdmin";
            this.apellidoAdmin.Size = new System.Drawing.Size(100, 20);
            this.apellidoAdmin.TabIndex = 2;
            // 
            // AnyoAdmin
            // 
            this.AnyoAdmin.Location = new System.Drawing.Point(111, 135);
            this.AnyoAdmin.Name = "AnyoAdmin";
            this.AnyoAdmin.ShowCheckBox = true;
            this.AnyoAdmin.Size = new System.Drawing.Size(230, 20);
            this.AnyoAdmin.TabIndex = 5;
            // 
            // groupBoxPaciente
            // 
            this.groupBoxPaciente.Controls.Add(this.anadirPaciente);
            this.groupBoxPaciente.Controls.Add(this.label17);
            this.groupBoxPaciente.Controls.Add(this.label18);
            this.groupBoxPaciente.Controls.Add(this.label19);
            this.groupBoxPaciente.Controls.Add(this.medicamentos);
            this.groupBoxPaciente.Controls.Add(this.label8);
            this.groupBoxPaciente.Controls.Add(this.label10);
            this.groupBoxPaciente.Controls.Add(this.nombrePaciente);
            this.groupBoxPaciente.Controls.Add(this.fechaAlta);
            this.groupBoxPaciente.Controls.Add(this.label9);
            this.groupBoxPaciente.Controls.Add(this.dniPaciente);
            this.groupBoxPaciente.Controls.Add(this.apellidoPaciente);
            this.groupBoxPaciente.Controls.Add(this.label7);
            this.groupBoxPaciente.Controls.Add(this.planta);
            this.groupBoxPaciente.Controls.Add(this.dniMedico);
            this.groupBoxPaciente.Location = new System.Drawing.Point(509, 582);
            this.groupBoxPaciente.Name = "groupBoxPaciente";
            this.groupBoxPaciente.Size = new System.Drawing.Size(555, 279);
            this.groupBoxPaciente.TabIndex = 38;
            this.groupBoxPaciente.TabStop = false;
            this.groupBoxPaciente.Text = "Añadir Paciente";
            this.groupBoxPaciente.Visible = false;
            // 
            // anadirPaciente
            // 
            this.anadirPaciente.Location = new System.Drawing.Point(462, 238);
            this.anadirPaciente.Name = "anadirPaciente";
            this.anadirPaciente.Size = new System.Drawing.Size(87, 35);
            this.anadirPaciente.TabIndex = 37;
            this.anadirPaciente.Text = "Añadir";
            this.anadirPaciente.UseVisualStyleBackColor = true;
            this.anadirPaciente.Click += new System.EventHandler(this.anadirPaciente_click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(43, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 7;
            this.label17.Text = "Nombre";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(43, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Apellido";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(43, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "DNI";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.Location = new System.Drawing.Point(111, 18);
            this.nombrePaciente.Name = "nombrePaciente";
            this.nombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.nombrePaciente.TabIndex = 1;
            // 
            // dniPaciente
            // 
            this.dniPaciente.Location = new System.Drawing.Point(111, 70);
            this.dniPaciente.Name = "dniPaciente";
            this.dniPaciente.Size = new System.Drawing.Size(100, 20);
            this.dniPaciente.TabIndex = 3;
            // 
            // apellidoPaciente
            // 
            this.apellidoPaciente.Location = new System.Drawing.Point(111, 44);
            this.apellidoPaciente.Name = "apellidoPaciente";
            this.apellidoPaciente.Size = new System.Drawing.Size(100, 20);
            this.apellidoPaciente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(43, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Planta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // planta
            // 
            this.planta.Location = new System.Drawing.Point(111, 100);
            this.planta.Name = "planta";
            this.planta.Size = new System.Drawing.Size(100, 20);
            this.planta.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(144, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(768, 251);
            this.listBox1.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 878);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxPaciente);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.groupBoxMedico);
            this.Controls.Add(this.buttonVerPaciente);
            this.Controls.Add(this.buttonVerAdmin);
            this.Controls.Add(this.buttonVerMedico);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonPaciente);
            this.Controls.Add(this.buttonMedico);
            this.Name = "Form1";
            this.Text = "Gestion Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMedico.ResumeLayout(false);
            this.groupBoxMedico.PerformLayout();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.groupBoxPaciente.ResumeLayout(false);
            this.groupBoxPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMedico;
        private System.Windows.Forms.Button buttonPaciente;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonVerMedico;
        private System.Windows.Forms.Button buttonVerAdmin;
        private System.Windows.Forms.Button buttonVerPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox dniMedico;
        private System.Windows.Forms.TextBox sueldo;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.DateTimePicker anyoIncorporacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox medicamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox especialidad;
        private System.Windows.Forms.ListBox departamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button anadirMedico;
        private System.Windows.Forms.GroupBox groupBoxMedico;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nombreAdmin;
        private System.Windows.Forms.TextBox sueldoAdmin;
        private System.Windows.Forms.TextBox dniAdmin;
        private System.Windows.Forms.TextBox apellidoAdmin;
        private System.Windows.Forms.DateTimePicker AnyoAdmin;
        private System.Windows.Forms.GroupBox groupBoxPaciente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox nombrePaciente;
        private System.Windows.Forms.TextBox dniPaciente;
        private System.Windows.Forms.TextBox apellidoPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox planta;
        private System.Windows.Forms.Button anadirAdmin;
        private System.Windows.Forms.Button anadirPaciente;
        private System.Windows.Forms.ListBox listBox1;
    }
}

