using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    internal class Pelicula
    {
        private string nombre;
        private int duracion;
        private int cantEntradas;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int CantEntradas { get => cantEntradas; set => cantEntradas = value; }

        public static List<Pelicula> listaPeliculas;

        public Pelicula(string nombre, int duracion,int cantEntradas) 
        { 
            this.nombre = nombre;
            this.Duracion = duracion;
            this.CantEntradas= cantEntradas;
        }
    }
}
