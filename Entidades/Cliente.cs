using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hulej.Francisco._2C.TPFinal
{
    public class Cliente : Persona
    {

        private double tarjeta;
        private Guid id;
        private int cantEntradas;
        private int idPelicula;
        private int idComboBox;
        public double Tarjeta { get => tarjeta; set => tarjeta = value; }
        public Guid Id { get => id; }
        public int CantEntradas { get => cantEntradas; set => cantEntradas = value; }
        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public int IdComboBox { get => idComboBox; set => idComboBox = value; }

        public Cliente(string nombre, string apellido, double dni, double tarjeta, int cantEntradas, int idPelicula, int idComboBox) : base(nombre, apellido, dni)
        {
            this.Tarjeta = tarjeta;
            this.id = Guid.NewGuid();
            this.CantEntradas = cantEntradas;
            this.IdPelicula = idPelicula;
            this.idComboBox = idComboBox;
        }

        public static int ValidarDni(string dni)
        {
            if(dni.Length ==8) {
                return int.Parse(dni);
            }
            else
            {
                throw new DniInvalidException("El dni tiene mas o menos de 8 caracteres");
            }
        }

        public static double ValidarTarjeta(string tarjeta)
        {
            if (tarjeta.Length >12 && tarjeta.Length<18)
            {
                return double.Parse(tarjeta);
            }
            else
            {
                throw new TarjetaInvalidException("La tarjeta no el numero de caracteres requerido");
            }
        }

        public static void SerializarClientesJson(List<Cliente> listaClientes, string path ,string archivo)
        {

            string dir = Path.Combine(path, archivo);
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(dir))
            {
                foreach (Cliente a in listaClientes)
                {
                    string clienteJson = JsonSerializer.Serialize(a, jsonSerializerOptions);
                    sw.WriteLine(clienteJson);
                }
            }
            
        }
        public static string DeSerializarClientesJson(string path, string archivo)
        {

            string dir = Path.Combine(path, archivo);     
            List <Cliente> clientesImportados= new List<Cliente>();
            using (StreamReader sr = new StreamReader(dir))
            {
                string json = sr.ReadToEnd();
                clientesImportados = JsonSerializer.Deserialize<List<Cliente>>(json);
                string nombre=clientesImportados[0].Nombre;
                return nombre;
            }

        }
    }

}
