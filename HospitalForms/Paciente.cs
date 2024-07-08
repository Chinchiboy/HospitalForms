using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente : Persona
    {
        public int Planta { get; set; }
        public List<string> Alergias { get; set; }
        public List<string> Medicamentos { get; set; }
        public DateTime FechaAlta { get; set; }
        public string DNIMedico { get; set; }

        public Paciente(string nombre, string apellido, string dni, int planta, List<string> alergias, List<string> medicamentos, DateTime fechaIngreso, string dniMedico) : base(nombre, apellido, dni)
        {
            Planta = planta;
            Alergias = alergias;
            Medicamentos = medicamentos;
            FechaAlta = fechaIngreso;
            DNIMedico = dniMedico;
        }

        public Paciente(string nombre, string apellido, string dni, int planta, List<string> medicamentos, DateTime fechaAlta, string dniMedico) : base(nombre, apellido, dni)
        {
            Planta = planta;
            Medicamentos = medicamentos;
            FechaAlta = fechaAlta;
            DNIMedico = dniMedico;
        }

        public override string ToString()
        {
            string alergiasStr = string.Join(", ", Alergias);
            string medicamentosStr = string.Join(", ", Medicamentos);

            return $"Paciente: {Nombre} {Apellido}\n" +
                   $"DNI: {DNI}\n" +
                   $"Planta: {Planta}\n" +
                   $"Medicamentos: {medicamentosStr}\n" +
                   $"Fecha de Ingreso: {FechaAlta.ToShortDateString()}";
        }
    }
}
