using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fechaNacimiento;
        public string biografia;

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.biografia = biografia;
        }

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }
    }
}
