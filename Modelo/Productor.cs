using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Productor : Persona
    {
        public Productor(string nombre, string apellido, DateTime fechaNacimiento, string biografia) : base(nombre,apellido, fechaNacimiento, biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.biografia = biografia;
        }
    }
}
