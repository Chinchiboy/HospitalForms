using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal abstract class Empleado : Persona
    {
        public double Sueldo { get; set; }
        public int AnyoIncorporacion { get; set; }

        protected Empleado(string nombre, string apellido, string dni, double sueldo, int anioIncorporacion) : base(nombre, apellido, dni)
        {
            Sueldo = sueldo;
            AnyoIncorporacion = anioIncorporacion;
        }
    }
}
