﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Tipo_pago
    {
        private int id_tipo;
        private string nombre;

        public Deta_Producto(int id_tipo, string nombre)
        {
            this.id_tipo = id_tipo;
            this.nombre = nombre;
         
        }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Nombre { get => nombre; set => nombre = value; }
    }

        
}

