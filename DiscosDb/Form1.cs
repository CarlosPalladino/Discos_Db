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
            cboCampo.Items.Add("CantidadCanciones");
            cboCampo.Items.Add("Titulo");






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
            FrmAltaDiscos modificar = new FrmAltaDiscos(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            Discos seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿estas seguro que lo borras ?", "eliminado !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
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

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "TiposEdicion")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Igual a");


            }
            else if (opcion == "CantidadCanciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Igual a");

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Metodos metodo = new Metodos();

            try
            {

                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzando.Text;

                dgvDiscos.DataSource = metodo.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show(" ¡ Seleccionado un Campo por favor !");
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show(" ¡ Seleccionado un Criterio, por favor !");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "CantidadCanciones") // aca problema
                if (string.IsNullOrEmpty(txtFiltroAvanzando.Text))
                {
                    MessageBox.Show("Selecciona una cantidad ");
                    return true;
                }
            return false;



        }
    }
}