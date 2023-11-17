using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public class Empleado : Persona
    {

        private string puesto;
        private int horasATrabajar;

        public string Puesto { get => puesto; }
        public int HorasATrabajar { get => horasATrabajar; set => horasATrabajar = value; }

        public Empleado(string nombre, string apellido, double dni, int jornada) : base(nombre, apellido, dni)
        {
            this.puesto = "Vendedor";
            this.HorasATrabajar = jornada;
        }

        public static List<Empleado> listaEmpleados = new List<Empleado>();
    }
}
