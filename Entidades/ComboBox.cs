using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    internal class ComboBox:IProducto<ComboBox>
    {
        private string nombre;
        private int id;
        private int valor;
        private int stock;

        
        public List<ComboBox> Productos=new List<ComboBox>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Valor { get => valor; set => valor = value; }
        public int Stock { get => stock; set => stock = value; }

        public ComboBox(string nombre,int id,int valor,int stock)
        {
            this.nombre = nombre;
            this.id = id;
            this.valor = valor;
            this.stock=stock;

        }

        public bool QuitarProducto(List<ComboBox> comboBox,string nombre)
        {
            
            foreach(ComboBox c in comboBox) {
                if(c.nombre == nombre)
                {
                    c.stock--;
                    return true;
                }
            }
            return false;
        }
    }
}
