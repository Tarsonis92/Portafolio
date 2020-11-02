using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Producto 
    {
        private int id_producto;
        private string nombre;
        private int precio;
        private DateTime tiempo_preparacion;
        private string descripcion;
        private string imagen;
        private int cate_prod_id_categoria;

        public Producto(int id_producto, string nombre, int precio,DateTime tiempo_preparacion, string descripcion, string imagen, int cate_prod_id_categoria)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.precio = precio;
            this.tiempo_preparacion = tiempo_preparacion;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.cate_prod_id_categoria = cate_prod_id_categoria;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Tiempo_preparacion { get => tiempo_preparacion; set => tiempo_preparacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Cate_prod_id_categoria { get => cate_prod_id_categoria; set => cate_prod_id_categoria = value; }
    }
}
