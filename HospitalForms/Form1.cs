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
            DisplayMedicos();
        }

        private void buttonVerAdmin_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            DisplayAdministrativos();
        }

        private void buttonVerPaciente_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            DisplayPacientes();
        }

        private void anadirMedico_click(object sender, EventArgs e)
        {
            if (CamposMedicoVisibles())
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
                }
            }
        }

        private void anadirAdmin_click(object sender, EventArgs e)
        {
            if (CamposAdminVisibles())
            {
                if (ValidarAdmin())
                {
                    Administrativo a = new Administrativo(
                        nombre.Text,
                        apellido.Text,
                        dni.Text,
                        double.Parse(sueldo.Text),
                        DateTime.Parse(anyoIncorporacion.Text),
                        departamento.SelectedItem.ToString()
                    );
                    administrativos.Add(a);
                    MessageBox.Show("Administrativo añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void anadirPaciente_click(object sender, EventArgs e)
        {
            if (CamposPacienteVisibles())
            {
                if (ValidarPaciente())
                {
                    Paciente paciente = new Paciente(
                        nombre.Text,
                        apellido.Text,
                        dni.Text,
                        int.Parse(planta.Text),
                        new List<string>(),
                        medicamentos.SelectedItems.Cast<string>().ToList(),
                        fechaAlta.Value,
                        dniMedico.Text
                    );
                    pacientes.Add(paciente);
                    MessageBox.Show("Paciente añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(apellido.Text) ||
                string.IsNullOrWhiteSpace(dni.Text) ||
                string.IsNullOrWhiteSpace(sueldo.Text) ||
                departamento.SelectedItem == null ||
                string.IsNullOrWhiteSpace(anyoIncorporacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios para añadir un administrativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarPaciente()
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) ||
                string.IsNullOrWhiteSpace(apellido.Text) ||
                string.IsNullOrWhiteSpace(dni.Text) ||
                string.IsNullOrWhiteSpace(planta.Text) ||
                medicamentos.SelectedItems.Count == 0 ||
                string.IsNullOrWhiteSpace(dniMedico.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios para añadir un paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SetAllInvisible()
        {
            groupBoxMedico.Visible = false;
            groupBoxAdmin.Visible = false;
            groupBoxPaciente.Visible = false;
        }

        private bool CamposMedicoVisibles()
        {
            return label1.Visible && label6.Visible && especialidad.Visible;
        }

        private bool CamposAdminVisibles()
        {
            return label12.Visible && departamento.Visible;
        }

        private bool CamposPacienteVisibles()
        {
            return label7.Visible && planta.Visible;
        }

        private void DisplayMedicos()
        {
            var displayText = string.Join("\n\n", medicos.Select(m => m.ToString()));
            MessageBox.Show(displayText, "Lista de Médicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayAdministrativos()
        {
            var displayText = string.Join("\n\n", administrativos.Select(a => a.ToString()));
            MessageBox.Show(displayText, "Lista de Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayPacientes()
        {
            var displayText = string.Join("\n\n", pacientes.Select(p => p.ToString()));
            MessageBox.Show(displayText, "Lista de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lógica cuando cambia el texto en textBox1
        }

        private void departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica cuando se selecciona un nuevo departamento
        }

        private void groupBox1_Enter(object sender, EventArgs e){ }
        private void label7_Click(object sender, EventArgs e){ }
        private void label9_Click(object sender, EventArgs e){ }
        private void groupBoxPaciente_Enter(object sender, EventArgs e){ }
    }
}
