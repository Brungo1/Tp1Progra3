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

namespace Tp1Progra3.Formularios
{
    public partial class frmMarcas : Form
    {
        List<Marca> listaMarcas;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.Listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tlsCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            frmCategorias.Show();
            this.Close();
        }

        private void tlsArticulos_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MainMenu"].Show();
            this.Close();
        }

        private void frmMarcas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmCategorias"] == null)
            {
                Application.OpenForms["MainMenu"].Show();
            }
        }
    }
}
