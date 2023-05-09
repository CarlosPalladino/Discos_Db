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
        private Discos discos = null;
        public FrmAltaDiscos()
        {
            InitializeComponent();
        }


        public FrmAltaDiscos(Discos disco)
        {
            InitializeComponent();
            this.discos = disco;
            Text = "modficacion";

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

                if (discos != null)
                {
                    txtTitulo.Text = discos.titulo;
                    txtCanciones.Text = discos.CantidadCanciones.ToString();
                    CargarImagen(discos.UrlImagenTapa);

                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();

            try
            {
                if (discos == null)
                    discos = new Discos();

                discos.titulo = txtTitulo.Text;
                discos.CantidadCanciones = int.Parse(txtCanciones.Text);
                discos.FechaLanzamiento = DateTime.Parse(dataFecha.Value.ToString());
                discos.UrlImagenTapa = txtImagen.Text;

                discos.Estilo = (Estilos)cboEstilos.SelectedItem;

                discos.TiposEdicion = (TiposEdicion)cboTipoEdicion.SelectedItem;
                if (discos.Id != 0)
                {

                    metodos.Modificar(discos);
                    MessageBox.Show("Modificado exitosamente");
                    Close();



                }
                else
                {
                    metodos.Nuevo(discos);
                    MessageBox.Show("Agregado Existosamente");
                    Close();

                }

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
