using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;

namespace DiscosDb
{
    public partial class Form1 : Form
    {
        private List<Discos> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Metodos metodo = new Metodos();

            try
            {

                listaDiscos = metodo.listar();
                dgvDiscos.DataSource = listaDiscos;

            }
            catch (Exception ex)
            {

                throw ex;
            }   
        }
    }
}
