using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    internal class Producto
    {
        public enum tiposDeProducto
        {
            Gaseosa,
            Golosina,
            Snak,
        }
        private string nombre;
        private int id;
        private int valor;
        private int stock;
        public tiposDeProducto tipoProducto;
        
        public List<Producto> Productos=new List<Producto>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Valor { get => valor; set => valor = value; }
        public int Stock { get => stock; set => stock = value; }

        public Producto(string nombre,int id,int valor,int stock,tiposDeProducto tipoProducto)
        {
            this.nombre = nombre;
            this.id = id;
            this.valor = valor;
            this.stock=stock;
            this.tipoProducto = tipoProducto;

        }
    }
}
