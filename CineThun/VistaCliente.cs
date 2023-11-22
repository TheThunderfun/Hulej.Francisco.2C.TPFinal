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

namespace CineThun
{
    public partial class VistaCliente : Form
    {
        public VistaCliente()
        {
            InitializeComponent();
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            List<Cliente> listaClientes = new List<Cliente>();
            GestorSql.GetAllClientes(listaClientes);
            GestorSql.GetAllPeliculas(listaPeliculas);
            for (int i = 1; i <= 5; i++)
            {
                cmbCantEntradas.Items.Add(i);
                cmbComboBox.Items.Add(i);
                cmbPeliculas.Items.Add(i);
            }


        }

        private void btnComprarEntardas_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != null && txtApellido.Text != null && txtDni.Text != null && txtTarjeta.Text != null && cmbCantEntradas.SelectedIndex < 0)
            {
            Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text,Double.Parse(txtDni.Text),Double.Parse(txtTarjeta.Text),cmbCantEntradas.SelectedIndex+1,1,cmbComboBox.SelectedIndex+1);
            GestorSql.NuevoCliente(cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Tarjeta, cliente.CantEntradas, cliente.IdPelicula, cliente.Id, cliente.IdComboBox);
            }
        }
    }
}
