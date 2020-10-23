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
        private string vencimiento;

        public Ingrediente(int id_ingrediente, string nombre, string vencimiento)
        {
            this.id_ingrediente = id_ingrediente;
            this.nombre = nombre;
            this.vencimiento = vencimiento;
        }

        public int Id_ingrediente { get => id_ingrediente; set => id_ingrediente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Vencimiento { get => vencimiento; set => vencimiento = value; }
    }
}
