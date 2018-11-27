using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estudio
    {
        public string nombre;
        public string direccion;
        public DateTime fechaApertura;

        public Estudio(string nombre, string direccion, DateTime fechaApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApertura = fechaApertura;
        }
        public override string ToString()
        {
            return $"{nombre} {fechaApertura}";
        }
    }
}
