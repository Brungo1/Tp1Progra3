using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        private int _Id;
        private int _IdArticulo;
        private string _UrlImagen;

        public int id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int idarticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }
        public string urlimagen
        {
            get { return _UrlImagen; }
            set { _UrlImagen = value; }
        }
    }
}
