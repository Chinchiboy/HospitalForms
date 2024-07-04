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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonMedico_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            MostrarCamposMedico();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            MostrarCamposAdmin();
        }

        private void buttonPaciente_Click(object sender, EventArgs e)
        {
            SetAllInvisible();
            MostrarCamposPaciente();
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

        private void anadir_click(object sender, EventArgs e)
        {
            if (CamposMedicoVisibles())
            {
                if (ValidarMedico())
                {
                    var medico = new Medico(
                        nombre.Text,
                        apellido.Text,
                        dni.Text,
                        double.Parse(sueldo.Text),
                        int.Parse(anyoIncorporacion.Text),
                        especialidad.SelectedItem.ToString()
                    );
                    medicos.Add(medico);
                    MessageBox.Show("Médico añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            else if (CamposAdminVisibles())
            {
                if (ValidarAdmin())
                {
                    var admin = new Administrativo(
                        nombre.Text,
                        apellido.Text,
                        dni.Text,
                        double.Parse(sueldo.Text),
                        int.Parse(anyoIncorporacion.Text),
                        departamento.SelectedItem.ToString()
                    );
                    administrativos.Add(admin);
                    MessageBox.Show("Administrativo añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            else if (CamposPacienteVisibles())
            {
                if (ValidarPaciente())
                {
                    var paciente = new Paciente(
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
                    LimpiarCampos();
                }
            }
        }

        private void LimpiarCampos()
        {
            nombre.Text = "";
            apellido.Text = "";
            dni.Text = "";
            sueldo.Text = "";
            especialidad.ClearSelected();
            anyoIncorporacion.Text = "";
            dniMedico.Text = "";
            planta.Text = "";
            medicamentos.ClearSelected();
            departamento.ClearSelected();
            fechaAlta.Value = DateTime.Now;
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
            label1.Visible = false;
            nombre.Visible = false;
            label2.Visible = false;
            apellido.Visible = false;
            label3.Visible = false;
            dni.Visible = false;
            label4.Visible = false;
            sueldo.Visible = false;
            label5.Visible = false;
            anyoIncorporacion.Visible = false;
            label6.Visible = false;
            especialidad.Visible = false;
            label12.Visible = false;
            departamento.Visible = false;
            planta.Visible = false;
            label9.Visible = false;
            fechaAlta.Visible = false;
            label10.Visible = false;
            dniMedico.Visible = false;
            label8.Visible = false;
            medicamentos.Visible = false;
        }

        private void MostrarCamposMedico()
        {
            label1.Visible = true;
            nombre.Visible = true;
            label2.Visible = true;
            apellido.Visible = true;
            label3.Visible = true;
            dni.Visible = true;
            label4.Visible = true;
            sueldo.Visible = true;
            label5.Visible = true;
            anyoIncorporacion.Visible = true;
            label6.Visible = true;
            especialidad.Visible = true;
        }

        private void MostrarCamposAdmin()
        {
            label1.Visible = true;
            nombre.Visible = true;
            label2.Visible = true;
            apellido.Visible = true;
            label3.Visible = true;
            dni.Visible = true;
            label4.Visible = true;
            sueldo.Visible = true;
            label5.Visible = true;
            anyoIncorporacion.Visible = true;
            label12.Visible = true;
            departamento.Visible = true;
        }

        private void MostrarCamposPaciente()
        {
            label1.Visible = true;
            nombre.Visible = true;
            label2.Visible = true;
            apellido.Visible = true;
            label3.Visible = true;
            dni.Visible = true;
            label7.Visible = true;
            planta.Visible = true;
            label9.Visible = true;
            fechaAlta.Visible = true;
            label10.Visible = true;
            dniMedico.Visible = true;
            label8.Visible = true;
            medicamentos.Visible = true;
        }

        private bool CamposMedicoVisibles()
        {
            return label1.Visible && label6.Visible;
        }

        private bool CamposAdminVisibles()
        {
            return label12.Visible;
        }

        private bool CamposPacienteVisibles()
        {
            return label7.Visible;
        }

        private void DisplayMedicos()
        {
            textBox1.Clear();
            foreach (var medico in medicos)
            {
                textBox1.AppendText(medico.ToString() + Environment.NewLine);
            }
        }

        private void DisplayAdministrativos()
        {
            textBox1.Clear();
            foreach (var admin in administrativos)
            {
                textBox1.AppendText(admin.ToString() + Environment.NewLine);
            }
        }

        private void DisplayPacientes()
        {
            textBox1.Clear();
            foreach (var paciente in pacientes)
            {
                textBox1.AppendText(paciente.ToString() + Environment.NewLine);
            }
        }
    }
}
