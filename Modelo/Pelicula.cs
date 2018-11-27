using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pelicula
    {
        public string nombre;
        public Director director;
        public DateTime fechaEstreno;
        public string descripcion;
        public int presupuesto;
        public Estudio estudio;

        public Pelicula(string nombre, Director director, DateTime fechaEstreno, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstreno = fechaEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }

        public override string ToString()
        {
            return $"{nombre} {fechaEstreno}";
        }
    }
}
