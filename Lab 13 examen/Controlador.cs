using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Lab_13_examen
{
    class Controlador
    {
        BaseDeDatos baseDeDatos;

        public Controlador()
        {
            baseDeDatos = new BaseDeDatos();
        }

        public List<Persona> obtenerPersonas()
        {
            return baseDeDatos.personas;
        }
        public List<Estudio> obtenerEstudios()
        {
            return baseDeDatos.estudios;
        }
        public List<Pelicula> obtenerPeliculas()
        {
            return baseDeDatos.peliculas;
        }
        public List<PeliculaActor> obtenerPeliculasActores()
        {
            return baseDeDatos.peliculasActores;
        }
        public List<PeliculaProductor> obtenerPeliculasProductor()
        {
            return baseDeDatos.peliculasProductores;
        }
    }
}
