using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        private int _id;
        private string _Descripcion;

       public int id
        {
            get { return _id; }
            set { _id = value; }
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
