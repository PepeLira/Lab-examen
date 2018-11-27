using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class BaseDeDatos
    {
        public List<Persona> personas = new List<Persona>();
        public List<Estudio> estudios = new List<Estudio>();
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<PeliculaActor> peliculasActores = new List<PeliculaActor>();
        public List<PeliculaProductor> peliculasProductores = new List<PeliculaProductor>();

        public BaseDeDatos()
        {
            Director jamesCameron = new Director("James", "Cameron", new DateTime(1954,8,16),"James se come los mocos");
            Productor jamesCameron1 = new Productor("James", "Cameron", new DateTime(1954, 8, 16), "James se come los mocos");
            Productor jonLandau = new Productor("Jon", "Landau", new DateTime(1947, 2, 14), "Jon Landau (14 de mayo de 1947) es un crítico musical, mánager y productor musical estadounidense, más conocido ");
            Estudio fox = new Estudio("Fox Studios", "por ahi", new DateTime(1996, 12, 3));
            Pelicula titanic = new Pelicula("Titanic", jamesCameron, new DateTime(1997, 12, 19), "Mas mocos", 200000000, fox);
            Actor leo = new Actor("Leonardo", "DiCaprio", new DateTime(1974, 11, 11),"Leonardo Wilhelm DiCaprio1​ (Los Ángeles, 11 de noviembre de 1974)2​ es un actor");
            Actor kate = new Actor("Kate", "Winslet", new DateTime(1975, 11, 5), "Kate Elizabeth Winslet, CBE (Reading, Inglaterra, 5 de octubre de 1975) es una actriz");
            PeliculaActor a = new PeliculaActor(titanic, leo);
            PeliculaActor b = new PeliculaActor(titanic, kate);
            PeliculaProductor c = new PeliculaProductor(titanic, jamesCameron1);
            PeliculaProductor d = new PeliculaProductor(titanic, jonLandau);

            personas.Add(jamesCameron); personas.Add(jamesCameron1); personas.Add(jonLandau); personas.Add(leo); personas.Add(kate);
            estudios.Add(fox);
            peliculas.Add(titanic);
            peliculasActores.Add(a); peliculasActores.Add(b);
            peliculasProductores.Add(c); peliculasProductores.Add(d);

        }

    }
}
