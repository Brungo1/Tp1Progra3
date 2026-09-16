using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        private int _Id;
        private string _Descripcion;

        public int id
            {
            get { return _Id; }
            set { _Id = value; }
            }
        public string descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public override string ToString()
        {
            return descripcion;
        }
    }
}
