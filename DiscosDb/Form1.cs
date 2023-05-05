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
            Cargar();
        }

        public void Cargar()
        {
            Metodos metodo = new Metodos();

            try
            {

                listaDiscos = metodo.listar();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();
                CargarImagen(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["IdEstilo"].Visible = false;
            dgvDiscos.Columns["IdTipoEdicion"].Visible = false;
             

        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Discos seleccion = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                CargarImagen(seleccion.UrlImagenTapa);
            }

        }

        public void CargarImagen(string imagen)
        {
            try
            {
                pickImg.Load(imagen);
            }
            catch (Exception)
            {
                pickImg.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           FrmAltaDiscos alta = new FrmAltaDiscos();
            alta.ShowDialog();
            Cargar();
        }
    }
}
