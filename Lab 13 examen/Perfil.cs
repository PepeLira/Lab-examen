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
    public partial class Perfil : Form
    {
        
        public Perfil(object cosa,List<PeliculaActor> peliculasActores,List<PeliculaProductor> peliculasProductores)
        {
            InitializeComponent();
            Type tipo = cosa.GetType();

            if (tipo == typeof(Actor) || tipo == typeof(Director) || tipo == typeof(Productor))
            {
                if(tipo == typeof(Actor))
                {
                    string peliculas = "";
                    foreach (PeliculaActor pa in peliculasActores)
                    {
                        if (cosa == pa.actor)
                        {
                            peliculas += " " + pa.pelicula.nombre;
                        }
                    }
                    label3.Visible = true;
                    label3.Text = "Peliculas: " + peliculas;
                }
                else if (tipo == typeof(Productor))
                {
                    string peliculas = "";
                    foreach (PeliculaProductor pp in peliculasProductores)
                    {
                        if (cosa == pp.productor)
                        {
                            peliculas += " " + pp.pelicula.nombre;
                        }
                    }
                    label3.Visible = true;
                    label3.Text = "Peliculas: " + peliculas;
                }
                Persona persona = (Persona)cosa;
                nombreLabel.Text = persona.nombre + persona.apellido;
                label2.Visible = true;
                label2.Text = "Fecha de nacimiento: " + persona.fechaNacimiento.ToString();
                richTextBox1.Visible = true;
                richTextBox1.Text = persona.biografia;
                


            }
            else if (tipo == typeof(Pelicula))
            {
                Pelicula pelicula = (Pelicula)cosa;
                nombreLabel.Text = pelicula.nombre;
                label2.Visible = true;
                label2.Text = "Fecha de estreno: " + pelicula.fechaEstreno.ToString();
                richTextBox1.Visible = true;
                richTextBox1.Text = pelicula.descripcion;
                label3.Visible = true;
                label3.Text = "Director: " + pelicula.director.nombre+" "+ pelicula.director.apellido;
                label4.Visible = true;
                label4.Text = "Presupuesto: "+pelicula.presupuesto.ToString();
                label1.Visible = true;
                label1.Text = "Estudio: " + pelicula.estudio.nombre + " " + pelicula.estudio.direccion;
            }
            else if (tipo == typeof(Estudio))
            {
                Estudio estudio = (Estudio)cosa;
                nombreLabel.Text = estudio.nombre;
                label2.Visible = true;
                label2.Text = "Fecha de apertura: " + estudio.fechaApertura.ToString();
                label3.Visible = true;
                label3.Text = "Direccion: " + estudio.direccion;
            }



        }
    }
}
