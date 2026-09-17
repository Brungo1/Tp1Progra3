using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1Progra3.Formularios
{
    public partial class frmAltaArticulo : Form
    {
        private List<Imagen> listaImagenes = new List<Imagen>();
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.codigo = txtCodigo.Text;
                nuevo.nombre = txtNombre.Text;
                nuevo.descripcion = txtDescripcion.Text;

                nuevo.marca = (Marca)cboIdMarca.SelectedItem;
                nuevo.categoria = (Categoria)cboIdCategoria.SelectedItem;

                nuevo.precio = decimal.Parse(txtPrecio.Text);

                negocio.Agregar(nuevo);

                MessageBox.Show("Artículo agregado correctamente");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboIdMarca.DataSource = marcaNegocio.Listar();
                cboIdMarca.ValueMember = "id";
                cboIdMarca.DisplayMember = "descripcion";

                cboIdCategoria.DataSource = categoriaNegocio.Listar();
                cboIdCategoria.ValueMember = "id";
                cboIdCategoria.DisplayMember = "descripcion";

                cboIdMarca.SelectedIndex = 0;
                cboIdCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

