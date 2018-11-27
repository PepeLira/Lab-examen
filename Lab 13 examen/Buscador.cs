using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Lab_13_examen
{
    public delegate List<Persona> obtenerBaseDeDatos();
    public delegate List<Estudio> obtenerBaseDeDatos1();
    public delegate List<Pelicula> obtenerBaseDeDatos2();
    public delegate List<PeliculaActor> obtenerBaseDeDatos3();
    public delegate List<PeliculaProductor> obtenerBaseDeDatos4();
    public partial class Buscador : Form
    {
        public event obtenerBaseDeDatos onObtenerPersonas;
        public event obtenerBaseDeDatos1 onObtenerEstudios;
        public event obtenerBaseDeDatos2 onObtenerPeliculas;
        public event obtenerBaseDeDatos3 onObtenerPeliculasActores;
        public event obtenerBaseDeDatos4 onObtenerPeliculasProductor;

        public List<Persona> personas;
        public List<Estudio> estudios;
        public List<Pelicula> peliculas;
        public List<PeliculaActor> peliculasActores;
        public List<PeliculaProductor> peliculasProductores;

        public Buscador()
        {
            InitializeComponent();
        }

        void obtenerBaseDeDatos()
        {
            personas = onObtenerPersonas.Invoke();
            estudios = onObtenerEstudios.Invoke();
            peliculas = onObtenerPeliculas.Invoke();
            peliculasActores = onObtenerPeliculasActores.Invoke();
            peliculasProductores = onObtenerPeliculasProductor.Invoke();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            sugerenciasSearch.Visible = false;
            sugerenciasSearch.Items.Clear();
            obtenerBaseDeDatos();
            if (searchBar.Text.Length >= 3)
            {
                List<Persona> matchPersona = personas.Where(x => (x.nombre.ToLower().Contains(searchBar.Text.ToLower()) || x.apellido.ToLower().Contains(searchBar.Text.ToLower()) || x.biografia.ToLower().Contains(searchBar.Text.ToLower()) || x.fechaNacimiento.ToString().Contains(searchBar.Text.ToLower()))).ToList();
                List<Estudio> matchEstudio = estudios.Where(x => (x.nombre.ToLower().Contains(searchBar.Text.ToLower()) || x.direccion.ToLower().Contains(searchBar.Text.ToLower()) || x.fechaApertura.ToString().Contains(searchBar.Text.ToLower()))).ToList();
                List<Pelicula> MatchPelicula = peliculas.Where(x => (x.nombre.ToLower().Contains(searchBar.Text.ToLower()) || x.director.nombre.ToLower().Contains(searchBar.Text.ToLower()) || x.director.apellido.ToLower().Contains(searchBar.Text.ToLower()) || x.fechaEstreno.ToString().Contains(searchBar.Text.ToLower()) || x.descripcion.ToLower().Contains(searchBar.Text.ToLower()) || x.estudio.nombre.ToLower().Contains(searchBar.Text.ToLower()) || x.presupuesto.ToString().Contains(searchBar.Text.ToLower()))).ToList();
                foreach (Persona persona in matchPersona)
                {
                    sugerenciasSearch.Items.Add(persona);
                    foreach (PeliculaActor pa in peliculasActores)
                    {
                        if(persona == pa.actor)
                        {
                            sugerenciasSearch.Items.Add(pa.pelicula);
                        }
                    }
                    foreach (PeliculaProductor pp in peliculasProductores)
                    {
                        if (persona == pp.productor)
                        {
                            sugerenciasSearch.Items.Add(pp.pelicula);
                        }
                    }
                    sugerenciasSearch.Visible = true;

                }
                foreach (Estudio estudio in matchEstudio)
                {
                    sugerenciasSearch.Items.Add(estudio);
                    sugerenciasSearch.Visible = true;
                }
                foreach (Pelicula pelicula in MatchPelicula)
                {
                    sugerenciasSearch.Items.Add(pelicula);
                    foreach (PeliculaActor pa in peliculasActores)
                    {
                        if (pelicula == pa.pelicula)
                        {
                            sugerenciasSearch.Items.Add(pa.actor);
                        }
                    }
                    foreach (PeliculaProductor pp in peliculasProductores)
                    {
                        if (pelicula == pp.pelicula)
                        {
                            sugerenciasSearch.Items.Add(pp.productor);
                        }
                    }
                    sugerenciasSearch.Visible = true;
                }
                
            }

        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            obtenerBaseDeDatos();
            sugerenciasSearch.Items.Clear();
            foreach (Pelicula pelicula in peliculas)
            {
                sugerenciasSearch.Items.Add(pelicula);
            }
            sugerenciasSearch.Visible = true;
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            obtenerBaseDeDatos();
            sugerenciasSearch.Items.Clear();
            
            foreach (Actor actor in personas.Where(x => x.GetType() == typeof(Actor)).ToList())
            {
                sugerenciasSearch.Items.Add(actor);
            }
            sugerenciasSearch.Visible = true;
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            obtenerBaseDeDatos();
            sugerenciasSearch.Items.Clear();

            foreach (Director director in personas.Where(x => x.GetType() == typeof(Director)).ToList())
            {
                sugerenciasSearch.Items.Add(director);
            }
            sugerenciasSearch.Visible = true;
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            obtenerBaseDeDatos();
            sugerenciasSearch.Items.Clear();
            foreach (Productor productor in personas.Where(x => x.GetType() == typeof(Productor)).ToList())
            {
                sugerenciasSearch.Items.Add(productor);
            }
            sugerenciasSearch.Visible = true;
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            obtenerBaseDeDatos();
            sugerenciasSearch.Items.Clear();
            foreach (Estudio estudio in estudios)
            {
                sugerenciasSearch.Items.Add(estudio);
            }
            sugerenciasSearch.Visible = true;
        }

        private void sugerenciasSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form perfil = new Perfil(sugerenciasSearch.SelectedItem,peliculasActores,peliculasProductores);

            perfil.ShowDialog();
        }
    }
}
