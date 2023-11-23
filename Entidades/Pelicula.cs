using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Hulej.Francisco._2C.TPFinal
{
    public class Pelicula:IProducto<Pelicula>
    {
        private string nombre;
        private int duracion;
        private int cantEntradas;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int CantEntradas { get => cantEntradas; set => cantEntradas = value; }
        public int Id { get => id;}


        public Pelicula(string nombre, int duracion, int cantEntradas)
        {
            this.Nombre = nombre;
            this.Duracion = duracion;
            this.CantEntradas = cantEntradas;
        }

        public List<Pelicula> AgregarPelicula(List<Pelicula>listaPeliculas, string nombre, int duracion, int cantEntradas)
        {
            Pelicula nuevaPelicula = new Pelicula(nombre,duracion,cantEntradas);
            listaPeliculas.Add(nuevaPelicula);
            return listaPeliculas;
        }

        public bool QuitarProducto(List<Pelicula> pelicula,string nombre)
        {
            foreach (Pelicula c in pelicula)
            {
                if (c.nombre == nombre)
                {
                    c.cantEntradas--;
                    return true;
                }
            }
            return false;
        }

    }
}
