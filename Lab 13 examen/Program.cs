using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_13_examen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controlador controlador = new Controlador();
            Buscador buscador = new Buscador();
            buscador.onObtenerPersonas += controlador.obtenerPersonas;
            buscador.onObtenerEstudios += controlador.obtenerEstudios;
            buscador.onObtenerPeliculas += controlador.obtenerPeliculas;
            buscador.onObtenerPeliculasActores += controlador.obtenerPeliculasActores;
            buscador.onObtenerPeliculasProductor += controlador.obtenerPeliculasProductor;
            Application.Run(buscador);
        }
    }
}
