namespace Portafolio
{
    partial class Opciones_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBodega = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnProducto = new MetroFramework.Controls.MetroButton();
            this.btnIngrediente = new MetroFramework.Controls.MetroButton();
            this.btnMesa = new MetroFramework.Controls.MetroButton();
            this.btnOrden = new MetroFramework.Controls.MetroButton();
            this.btnProveedor = new MetroFramework.Controls.MetroButton();
            this.btnReservacion = new MetroFramework.Controls.MetroButton();
            this.btnFactura = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(48, 82);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(75, 23);
            this.btnBodega.TabIndex = 0;
            this.btnBodega.Text = "Bodega";
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(247, 82);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Finanzas";
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(149, 82);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(75, 23);
            this.btnProducto.TabIndex = 4;
            this.btnProducto.Text = "Producto";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnIngrediente
            // 
            this.btnIngrediente.Location = new System.Drawing.Point(340, 82);
            this.btnIngrediente.Name = "btnIngrediente";
            this.btnIngrediente.Size = new System.Drawing.Size(75, 23);
            this.btnIngrediente.TabIndex = 5;
            this.btnIngrediente.Text = "Ingrediente";
            this.btnIngrediente.Click += new System.EventHandler(this.btnIngrediente_Click);
            // 
            // btnMesa
            // 
            this.btnMesa.Location = new System.Drawing.Point(433, 82);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(75, 23);
            this.btnMesa.TabIndex = 6;
            this.btnMesa.Text = "Mesa";
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(86, 114);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(75, 23);
            this.btnOrden.TabIndex = 7;
            this.btnOrden.Text = "Orden";
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(190, 114);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnProveedor.TabIndex = 8;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnReservacion
            // 
            this.btnReservacion.Location = new System.Drawing.Point(289, 114);
            this.btnReservacion.Name = "btnReservacion";
            this.btnReservacion.Size = new System.Drawing.Size(75, 23);
            this.btnReservacion.TabIndex = 9;
            this.btnReservacion.Text = "Reservacion";
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(381, 114);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFactura.TabIndex = 10;
            this.btnFactura.Text = "Factura";
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // Opciones_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 155);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnReservacion);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.btnMesa);
            this.Controls.Add(this.btnIngrediente);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btnBodega);
            this.Name = "Opciones_Admin";
            this.Text = "Opciones_Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBodega;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnProducto;
        private MetroFramework.Controls.MetroButton btnIngrediente;
        private MetroFramework.Controls.MetroButton btnMesa;
        private MetroFramework.Controls.MetroButton btnOrden;
        private MetroFramework.Controls.MetroButton btnProveedor;
        private MetroFramework.Controls.MetroButton btnReservacion;
        private MetroFramework.Controls.MetroButton btnFactura;
    }
}