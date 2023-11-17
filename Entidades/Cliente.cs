using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public class Cliente : Persona
    {

        private double tarjeta;
        private Guid nTransaccion;
        private int cantEntradas;

        public double Tarjeta { get => tarjeta; set => tarjeta = value; }
        public Guid NTransaccion { get => nTransaccion; }
        public int CantEntradas { get => cantEntradas; set => cantEntradas = value; }

        public Cliente(string nombre, string apellido, double dni,double tarjeta, int cantEntradas) : base(nombre, apellido, dni)
        {
            this.Tarjeta = tarjeta;
            this.nTransaccion = Guid.NewGuid();
            this.CantEntradas=cantEntradas;
        }


 
    }
}
