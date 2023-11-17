namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private double dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Dni { get => dni; set => dni = value; }

        protected Persona(string nombre, string apellido, double dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }


    }
}