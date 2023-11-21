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
        private Guid id;
        private int cantEntradas;
        private int idPelicula;
        public double Tarjeta { get => tarjeta; set => tarjeta = value; }
        public Guid Id { get => id; }
        public int CantEntradas { get => cantEntradas; set => cantEntradas = value; }
        public int IdPelicula { get => idPelicula; set => idPelicula = value; }

        public Cliente(string nombre, string apellido, double dni, double tarjeta, int cantEntradas, int idPelicula) : base(nombre, apellido, dni)
        {
            this.Tarjeta = tarjeta;
            this.id = Guid.NewGuid();
            this.CantEntradas = cantEntradas;
            this.IdPelicula = idPelicula;
        }
        
        public List<Cliente> NuevoCliente(List<Cliente> listaClientes, string nombre, string apellido, double dni, double tarjeta, int cantEntradas, int idPelicula)
        {
            Cliente nuevoCliente = new Cliente(nombre, apellido, dni, tarjeta, cantEntradas, idPelicula);
            listaClientes.Add(nuevoCliente);
            return listaClientes;
        }
    
        public List<Cliente> EliminarCliente(List<Cliente> listaClientes,Guid nTransABuscar)
        {
            Cliente clienteAEliminar = listaClientes.FirstOrDefault(cliente => cliente.id == nTransABuscar);
            listaClientes.Remove(clienteAEliminar);
            return listaClientes;
        }

    }
}
