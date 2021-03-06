﻿using BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Administracion_Producto : MetroFramework.Forms.MetroForm
    {
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=porta_final;USER ID=porta_final");
        DAOAdmin admin = new DAOAdmin();
        public Administracion_Producto()
        {
            InitializeComponent();
        }
        Metodos_Tabla metodos = new Metodos_Tabla();
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Administrar_Usuario editar = new Administrar_Usuario();
            editar.Show();
        }

       
        private void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarTabla();
        }


        public void mostrarTabla() {

            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();

            con.Open();
            comando = new OracleCommand("SP_SELECT_USUARIO", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            metodos.mostrarTabla(comando, adaptador);
            adaptador.Fill(tabla);
            dgvTabla.DataSource = tabla;
            con.Close();

        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            admin.Actualizar_Producto(Convert.ToInt32(txtId_Producto.Text),txtNombre.Text,Convert.ToInt32(txtPrecio.Text),dtpTiempo_Preparacion.Value,lbxDescripcion.Text,Convert.ToInt32(cbxId_Cat_Prod.SelectedValue));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            admin.Agregar_Producto(txtNombre.Text,Convert.ToInt32(txtPrecio.Text),dtpTiempo_Preparacion.Value,lbxDescripcion.Text,Convert.ToInt32(cbxId_Cat_Prod));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            admin.Eliminar_Producto(Convert.ToInt32(txtId_Producto.Text));
        }
    }
}
