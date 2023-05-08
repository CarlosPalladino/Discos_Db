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
            cboCampo.Items.Add("Tapa");
            cboCampo.Items.Add("Disco");
            cboCampo.Items.Add("Nombre");

            cboCriterio.Items.Add("Criterio");




            Cargar();
        }

        public void Cargar()
        {
            Metodos metodo = new Metodos();

            try
            {

                listaDiscos = metodo.listar();
                dgvDiscos.DataSource = listaDiscos;
                CargarImagen(listaDiscos[0].UrlImagenTapa);
                ocultarColumnas();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
           FrmAltaDiscos  modificar = new FrmAltaDiscos(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           Metodos metodos = new Metodos(); 
            Discos seleccionado;
            try
            {
                DialogResult resultado =MessageBox.Show("¿estas seguro que lo borras ?","eliminado !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(resultado == DialogResult.Yes)
                {
                    seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    metodos.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
