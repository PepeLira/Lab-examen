using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PeliculaProductor
    {
        public Pelicula pelicula;
        public Productor productor;

        public PeliculaProductor(Pelicula pelicula, Productor productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
