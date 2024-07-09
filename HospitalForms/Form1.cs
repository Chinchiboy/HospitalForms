using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hospital;

namespace HospitalForms
{
    public partial class Form1 : Form
    {
        private List<Medico> medicos = new List<Medico>();
        private List<Administrativo> administrativos = new List<Administrativo>();
        private List<Paciente> pacientes = new List<Paciente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){ }

        private void buttonMedico_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            groupBoxMedico.Visible = true;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            groupBoxAdmin.Location = new System.Drawing.Point(33, 276);
            groupBoxAdmin.Visible = true;
        }

        private void buttonPaciente_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            groupBoxPaciente.Location = new System.Drawing.Point(33, 276);
            groupBoxPaciente.Visible = true;
        }

        private void buttonVerMedico_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            listBox1.Items.Clear();

            // Agregar encabezado
            listBox1.Items.Add("MOSTRANDO MÉDICOS");
            listBox1.Items.Add("");  // Línea vacía para separar el encabezado de la lista

            // Agregar elementos
            foreach (var medico in medicos)
            {
                listBox1.Items.Add(medico.ToString());
            }
        }

        private void buttonVerAdmin_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            listBox1.Items.Clear();

            // Agregar encabezado
            listBox1.Items.Add("MOSTRANDO ADMINISTRATIVOS");
            listBox1.Items.Add("");  // Línea vacía para separar el encabezado de la lista

            // Agregar elementos
            foreach (var admin in administrativos)
            {
                listBox1.Items.Add(admin.ToString());
            }
        }

        private void buttonVerPaciente_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            listBox1.Items.Clear();

            // Agregar encabezado
            listBox1.Items.Add("MOSTRANDO PACIENTES");
            listBox1.Items.Add("");  // Línea vacía para separar el encabezado de la lista

            // Agregar elementos
            foreach (var paciente in pacientes)
            {
                listBox1.Items.Add(paciente.ToString());
            }
        }


        private void anadirMedico_click(object sender, EventArgs e)
        {
                if (ValidarMedico())
                {
                    Medico m = new Medico(
                        nombre.Text,
                        apellido.Text,
                        dni.Text,
                        double.Parse(sueldo.Text),
                        DateTime.Parse(anyoIncorporacion.Text),
                        especialidad.SelectedItem.ToString()
                    );
                    medicos.Add(m);
                    MessageBox.Show("Médico añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
            
        }

        private void anadirAdmin_click(object sender, EventArgs e)
        {
                if (ValidarAdmin())
                {
                    Administrativo a = new Administrativo(
                        nombreAdmin.Text,
                        apellidoAdmin.Text,
                        dniAdmin.Text,
                        double.Parse(sueldoAdmin.Text),
                        DateTime.Parse(AnyoAdmin.Text),
                        departamento.SelectedItem.ToString()
                    );
                    administrativos.Add(a);
                    MessageBox.Show("Administrativo añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
            
        }

        private void LimpiarFormulario()
        {
            nombre.Text = string.Empty;
            nombreAdmin.Text = string.Empty;
            nombrePaciente.Text = string.Empty;
            apellido.Text = string.Empty;
            apellidoAdmin.Text = string.Empty;
            apellidoPaciente.Text = string.Empty;
            dni.Text = string.Empty;
            dniAdmin.Text = string.Empty;
            dniPaciente.Text = string.Empty;
            sueldo.Text = string.Empty;
            sueldoAdmin.Text = string.Empty;
            departamento.Text = string.Empty;
            especialidad.Text = string.Empty;
            planta.Text = string.Empty;
            dniMedico.Text = string.Empty;
        }

        private void anadirPaciente_click(object sender, EventArgs e)
        {
            if (ValidarPaciente())
            {
                Paciente paciente = new Paciente(
                    nombrePaciente.Text,
                    apellidoPaciente.Text,
                    dniPaciente.Text,
                    int.Parse(planta.Text),
                    new List<string>(),
                    medicamentos.SelectedItems.Cast<string>().ToList(),
                    fechaAlta.Value,
                    dniMedico.Text
                );
                pacientes.Add(paciente);
                MessageBox.Show("Paciente añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
        }

        private bool ValidarMedico()
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(apellido.Text) ||
                string.IsNullOrWhiteSpace(dni.Text) ||
                string.IsNullOrWhiteSpace(sueldo.Text) ||
                especialidad.SelectedItem == null ||
                string.IsNullOrWhiteSpace(anyoIncorporacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios para añadir un médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarAdmin()
        {
            if (string.IsNullOrWhiteSpace(nombreAdmin.Text) ||
                string.IsNullOrWhiteSpace(apellidoAdmin.Text) ||
                string.IsNullOrWhiteSpace(dniAdmin.Text) ||
                string.IsNullOrWhiteSpace(sueldoAdmin.Text) ||
                departamento.SelectedItem == null ||
                string.IsNullOrWhiteSpace(AnyoAdmin.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios para añadir un administrativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarPaciente()
        {
            foreach (Medico m in medicos)
            {
                if(m.DNI == dniMedico.Text)
                {
                    if (string.IsNullOrWhiteSpace(nombrePaciente.Text) ||
                        string.IsNullOrWhiteSpace(apellidoPaciente.Text) ||
                        string.IsNullOrWhiteSpace(dniPaciente.Text) ||
                        string.IsNullOrWhiteSpace(planta.Text) ||
                        medicamentos.SelectedItems.Count == 0 ||
                        string.IsNullOrWhiteSpace(dniMedico.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos necesarios para añadir un paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void SetAllInvisible()
        {
            groupBoxMedico.Visible = false;
            groupBoxAdmin.Visible = false;
            groupBoxPaciente.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si hay algún elemento seleccionado, hacer visible el botón Eliminar
            if (listBox1.SelectedIndex >= 0)
            {
                eliminar.Visible = true;
            }
            else
            {
                eliminar.Visible = false;
            }
        }
    }
}
