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
using Negocio;
using Tp1Progra3.Formularios;

namespace Tp1Progra3
{

    public partial class MainMenu : Form
    {
        private List<Articulo> listaArticulos;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();

                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tlsArchivo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lstbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void mstMenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ImagenNegocio imagenNegocio = new ImagenNegocio();

                try
                {
                    List<Imagen> listaImagenes = imagenNegocio.ListarPorArticulo(seleccionado.id);

                    if (listaImagenes.Count > 0)
                    {
                        pbxImagenProducto.Load(listaImagenes[0].urlimagen);
                    }
                    else
                    {
                        pbxImagenProducto.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                    }
                }
                catch (Exception)
                {
                    pbxImagenProducto.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo Ventana = new frmAltaArticulo();
            Ventana.ShowDialog();
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.Listar();
        }
    }
}
