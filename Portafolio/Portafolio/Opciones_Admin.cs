﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Opciones_Admin :  MetroFramework.Forms.MetroForm
    {
        public Opciones_Admin()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Administracion_Producto producto = new Administracion_Producto();
            producto.Show();
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            Administracion_Ingrediente ingrediente = new Administracion_Ingrediente();
            ingrediente.Show();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            Administra_Orden_Compra orden = new Administra_Orden_Compra();
            orden.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Administrar_Proveedor proveedor = new Administrar_Proveedor();
            proveedor.Show();
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            Administrar_Mesa mesa = new Administrar_Mesa();
            mesa.Show();
        }

       

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Administrar_Cuenta cuenta = new Administrar_Cuenta();
            cuenta.Show();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            Administrar_Comanda comanda = new Administrar_Comanda();
            comanda.Show();
        }
    }
}
