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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dniMedico = new System.Windows.Forms.TextBox();
            this.planta = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.anyoIncorporacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.medicamentos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.especialidad = new System.Windows.Forms.ListBox();
            this.departamento = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.anadir = new System.Windows.Forms.Button();
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
            this.buttonMedico.Click += new System.EventHandler(this.buttonPaciente_Click);
            // 
            // buttonPaciente
            // 
            this.buttonPaciente.Location = new System.Drawing.Point(33, 98);
            this.buttonPaciente.Name = "buttonPaciente";
            this.buttonPaciente.Size = new System.Drawing.Size(87, 34);
            this.buttonPaciente.TabIndex = 1;
            this.buttonPaciente.Text = "Añadir Paciente";
            this.buttonPaciente.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(33, 53);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(87, 39);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Añadir Administrativo";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonVerMedico
            // 
            this.buttonVerMedico.Location = new System.Drawing.Point(33, 138);
            this.buttonVerMedico.Name = "buttonVerMedico";
            this.buttonVerMedico.Size = new System.Drawing.Size(87, 33);
            this.buttonVerMedico.TabIndex = 3;
            this.buttonVerMedico.Text = "Ver Médico";
            this.buttonVerMedico.UseVisualStyleBackColor = true;
            // 
            // buttonVerAdmin
            // 
            this.buttonVerAdmin.Location = new System.Drawing.Point(33, 177);
            this.buttonVerAdmin.Name = "buttonVerAdmin";
            this.buttonVerAdmin.Size = new System.Drawing.Size(87, 38);
            this.buttonVerAdmin.TabIndex = 4;
            this.buttonVerAdmin.Text = "Ver Administrativos";
            this.buttonVerAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonVerPaciente
            // 
            this.buttonVerPaciente.Location = new System.Drawing.Point(33, 221);
            this.buttonVerPaciente.Name = "buttonVerPaciente";
            this.buttonVerPaciente.Size = new System.Drawing.Size(87, 34);
            this.buttonVerPaciente.TabIndex = 5;
            this.buttonVerPaciente.Text = "Ver Paciente";
            this.buttonVerPaciente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 243);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sueldo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Año de incorporación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Especialidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Visible = false;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(98, 286);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 13;
            this.nombre.Visible = false;
            // 
            // dniMedico
            // 
            this.dniMedico.Location = new System.Drawing.Point(367, 339);
            this.dniMedico.Name = "dniMedico";
            this.dniMedico.Size = new System.Drawing.Size(100, 20);
            this.dniMedico.TabIndex = 15;
            this.dniMedico.Visible = false;
            // 
            // planta
            // 
            this.planta.Location = new System.Drawing.Point(367, 286);
            this.planta.Name = "planta";
            this.planta.Size = new System.Drawing.Size(100, 20);
            this.planta.TabIndex = 18;
            this.planta.Visible = false;
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(98, 364);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(100, 20);
            this.sueldo.TabIndex = 21;
            this.sueldo.Visible = false;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(98, 338);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 22;
            this.dni.Visible = false;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(98, 312);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 23;
            this.apellido.Visible = false;
            // 
            // anyoIncorporacion
            // 
            this.anyoIncorporacion.Location = new System.Drawing.Point(98, 403);
            this.anyoIncorporacion.Name = "anyoIncorporacion";
            this.anyoIncorporacion.ShowCheckBox = true;
            this.anyoIncorporacion.Size = new System.Drawing.Size(200, 20);
            this.anyoIncorporacion.TabIndex = 24;
            this.anyoIncorporacion.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(320, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Planta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(560, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Medicamentos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Visible = false;
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
            this.medicamentos.Location = new System.Drawing.Point(647, 283);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.medicamentos.Size = new System.Drawing.Size(120, 95);
            this.medicamentos.TabIndex = 27;
            this.medicamentos.Visible = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(291, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Fecha de alta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Visible = false;
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(367, 313);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ShowCheckBox = true;
            this.fechaAlta.Size = new System.Drawing.Size(192, 20);
            this.fechaAlta.TabIndex = 29;
            this.fechaAlta.Visible = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(297, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "DNI Médico";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
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
            this.especialidad.Location = new System.Drawing.Point(98, 438);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(120, 95);
            this.especialidad.TabIndex = 32;
            this.especialidad.Visible = false;
            // 
            // departamento
            // 
            this.departamento.FormattingEnabled = true;
            this.departamento.Items.AddRange(new object[] {
            "Administracion,",
            "RecursosHumanos,",
            "Finanzas,",
            "Marketing"});
            this.departamento.Location = new System.Drawing.Point(367, 438);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(120, 95);
            this.departamento.TabIndex = 34;
            this.departamento.Visible = false;
            this.departamento.SelectedIndexChanged += new System.EventHandler(this.departamento_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(286, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 33;
            this.label12.Text = "Departamento";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // anadir
            // 
            this.anadir.Location = new System.Drawing.Point(680, 498);
            this.anadir.Name = "anadir";
            this.anadir.Size = new System.Drawing.Size(87, 35);
            this.anadir.TabIndex = 35;
            this.anadir.Text = "Añadir";
            this.anadir.UseVisualStyleBackColor = true;
            this.anadir.Click += new System.EventHandler(this.anadir_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.anadir);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.medicamentos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.anyoIncorporacion);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.planta);
            this.Controls.Add(this.dniMedico);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonVerPaciente);
            this.Controls.Add(this.buttonVerAdmin);
            this.Controls.Add(this.buttonVerMedico);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonPaciente);
            this.Controls.Add(this.buttonMedico);
            this.Name = "Form1";
            this.Text = "Gestion Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMedico;
        private System.Windows.Forms.Button buttonPaciente;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonVerMedico;
        private System.Windows.Forms.Button buttonVerAdmin;
        private System.Windows.Forms.Button buttonVerPaciente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox dniMedico;
        private System.Windows.Forms.TextBox planta;
        private System.Windows.Forms.TextBox sueldo;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.DateTimePicker anyoIncorporacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox medicamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox especialidad;
        private System.Windows.Forms.ListBox departamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button anadir;
    }
}

