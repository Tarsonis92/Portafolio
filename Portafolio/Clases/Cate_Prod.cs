using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Cate_Prod
    {
        private int id_categoria;
        private string nombre;
        private string descripcion;

        public Cate_Prod(int id_categoria, string nombre, string descripcion)
        {
            this.id_categoria = id_categoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
