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

namespace TPWinForm_equipoD.Formularios
{
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la categoría.");
                    return;
                }

                nueva.descripcion = txtDescripcion.Text;
                negocio.Agregar(nueva);

                MessageBox.Show("Categoría agregada exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar agregar: " + ex.Message);
            }
        }
    }
}
