using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Hulej.Francisco._2C.TPFinal;

namespace CineThun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            GestorSql.GetAllClientes(clientes);
            foreach (Cliente s in clientes)
            {
                MessageBox.Show(s.Id.ToString());
            } 
        }
    }
}
