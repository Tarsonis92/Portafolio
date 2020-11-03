using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Ingrediente
    {
        private int id_ingrediente;
        private string nombre;
        private DateTime fecha_vencimiento;
        private DateTime fecha_ingreso;
        private int stock;

        public Ingrediente(int id_ingrediente, string nombre, DateTime fecha_vencimiento, DateTime fecha_ingreso, int stock)
        {
            this.id_ingrediente = id_ingrediente;
            this.nombre = nombre;
            this.fecha_vencimiento = fecha_vencimiento;
            this.fecha_ingreso = fecha_ingreso;
            this.stock = stock;
        }

        public int Id_ingrediente { get => id_ingrediente; set => id_ingrediente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public string Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string Stock { get => stock; set => stock = value; }
    }
}
