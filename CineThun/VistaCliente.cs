using Hulej.Francisco._2C.TPFinal;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CineThun
{
    public partial class VistaCliente : Form
    {
        private Thread hiloCambiarPeliculas;
        string dir = "C:\\Users\\pc\\Source\\Repos\\Hulej.Francisco.2C.TPFinal";
        string archivoJson = "Clientes.json";
        List<Pelicula> listaPeliculas = new List<Pelicula>();
        List<Cliente> listaClientes = new List<Cliente>();
        public VistaCliente()
        {
            InitializeComponent();

            GestorSql.GetAllClientes(listaClientes);
            GestorSql.GetAllPeliculas(listaPeliculas);
            for (int i = 1; i <= 5; i++)
            {
                cmbCantEntradas.Items.Add(i);
                cmbComboBox.Items.Add(i);
                cmbPeliculas.Items.Add(i);
            }
            hiloCambiarPeliculas = new Thread(CambiarPeliculasPeriodicamente);
            hiloCambiarPeliculas.Start();

        }

        private void btnComprarEntardas_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != null && txtApellido.Text != null && txtDni.Text != null && txtTarjeta.Text != null)
                {
                    Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, Cliente.ValidarDni(txtDni.Text), Cliente.ValidarTarjeta(txtTarjeta.Text), cmbCantEntradas.SelectedIndex + 1, 1, cmbComboBox.SelectedIndex + 1);
                    GestorSql.NuevoCliente(cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Tarjeta, cliente.CantEntradas, cliente.IdPelicula, cliente.Id, cliente.IdComboBox);
                }
            }
            catch (DniInvalidException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (TarjetaInvalidException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato de Tarjeta o Dni es invalido");
            }

        }

        private void bttnEditarDatos_Click(object sender, EventArgs e)
        {
            Cliente.SerializarClientesJson(this.listaClientes, this.dir, this.archivoJson);
            //MessageBox.Show(Cliente.DeSerializarClientesJson(this.dir,this.archivoJson));
        }

        private void CambiarPeliculasPeriodicamente()
        {
            while (true)
            {
                Thread.Sleep(6000);
                BeginInvoke(new Action(() =>
                {
                    CambiarPeliculas();
                }));
            }
        }

        private void CambiarPeliculas()
        {
            int cantPeliculas = this.listaClientes.Count;

            cmbPeliculas.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int nRng = random.Next(0, cantPeliculas);
                cmbPeliculas.Items.Add(this.listaClientes[nRng].Nombre);
            }


        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {

        }

        private void VistaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            hiloCambiarPeliculas.Abort();
            base.Close();
        }
    }
}
