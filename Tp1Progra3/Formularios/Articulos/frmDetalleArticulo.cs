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

namespace TPWinForm_equipoD.Formularios
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        public frmDetalleArticulo(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articulo = articuloSeleccionado;
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblNombreArticulo.Text = articulo.nombre;
            lblDescripcionArticulo.Text = articulo.descripcion;

            lblPrecioArticulo.Text = "$" + articulo.precio.ToString("0.00");
        }
    }
}
