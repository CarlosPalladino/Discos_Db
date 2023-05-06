using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace DiscosDb
{
    public partial class FrmAltaDiscos : Form
    {
        public FrmAltaDiscos()
        {
            InitializeComponent();
        }



        private void FrmAltaDiscos_Load(object sender, EventArgs e)
        {

            TipoEdicionMetodo metodo = new TipoEdicionMetodo();
            EstiloMetodo met = new EstiloMetodo();

            try
            {
                cboEstilos.DataSource = met.listar();
                cboEstilos.ValueMember = "Id";
                cboEstilos.DisplayMember = "Descripcion";

                cboTipoEdicion.DataSource = metodo.listar();
                cboTipoEdicion.ValueMember = "Id";
                cboTipoEdicion.DisplayMember = "Descripcion";



            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            Discos disco = new Discos();
            try
            {
                disco.titulo = txtTitulo.Text;
                disco.CantidadCanciones = int.Parse(txtCanciones.Text);
                disco.FechaLanzamiento = DateTime.Parse(dataFecha.Value.ToString());
                disco.UrlImagenTapa = txtImagen.Text;
                disco.Estilo = (Estilos)cboEstilos.SelectedItem;
                disco.TiposEdicion = (TiposEdicion)cboTipoEdicion.SelectedItem;

                metodos.Nuevo(disco);
                MessageBox.Show("Agregado Existosamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CargarImagen(string imagen)
        {
            try
            {
                picImg.Load(imagen);
            }
            catch (Exception)
            {
                picImg.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");
            }

        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtImagen.Text);
        }
    }
}
