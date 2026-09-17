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

namespace Tp1Progra3
{
    public partial class frmAltaImagen : Form
    {
        private Articulo articuloLocal;
        public frmAltaImagen(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloLocal = articuloSeleccionado;
            MessageBox.Show("El ID recibido es: " + articuloLocal.id.ToString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen nuevaImagen = new Imagen();

            try
            {
                nuevaImagen.idarticulo = articuloLocal.id; 
                nuevaImagen.urlimagen = txtUrlImagen.Text; 

                negocio.Agregar(nuevaImagen);

                MessageBox.Show("Imagen agregada exitosamente.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar la imagen: " + ex.Message);
            }
        }
    }
}
