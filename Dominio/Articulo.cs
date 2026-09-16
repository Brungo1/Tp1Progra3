using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        private int _id;
        private string _codigo;
        private string _nombre;
        private string _descripcion;
        private Marca _marca;
        private Categoria _categoria;
        private decimal _precio;
        private List<Imagen> _imagenes;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Marca marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public Categoria categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public List<Imagen> imagenes
        {
            get { return _imagenes; }
            set { _imagenes = value; } 
        }
        
    }
    }
