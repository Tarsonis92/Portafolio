using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Estado_Pago
    {
        private int id_estado;
        private string nombre;

        public Estado_Pago(int id_estado, string nombre)
        {
            this.id_estado = id_estado;
            this.nombre = nombre;
        }

        public int Id_estado { get => id_estado; set => id_estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
