﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Bodega
    {
        private int id_bodega;
        private int stock;

        public Bodega(int id_bodega, int stock)
        {
            this.id_bodega = id_bodega;
            this.stock = stock;
        }

        public int Id_bodega { get => id_bodega; set => id_bodega = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
