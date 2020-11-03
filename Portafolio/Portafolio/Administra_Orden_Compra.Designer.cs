namespace Portafolio
{
    partial class Administra_Orden_Compra
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtId_Orden_Compra = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.dtpFecha_Emision = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxEstado_Pago = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbxObservacion = new System.Windows.Forms.ListBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtId_Proveedor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtId_Usuario = new MetroFramework.Controls.MetroTextBox();
            this.cbxId_Tipo = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id Compra:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(253, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Fecha Emision:";
            // 
            // txtId_Orden_Compra
            // 
            this.txtId_Orden_Compra.Location = new System.Drawing.Point(96, 65);
            this.txtId_Orden_Compra.Name = "txtId_Orden_Compra";
            this.txtId_Orden_Compra.Size = new System.Drawing.Size(151, 23);
            this.txtId_Orden_Compra.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(194, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 51);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(354, 209);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 51);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(502, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 51);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFecha_Emision
            // 
            this.dtpFecha_Emision.Location = new System.Drawing.Point(354, 71);
            this.dtpFecha_Emision.Name = "dtpFecha_Emision";
            this.dtpFecha_Emision.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Emision.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(560, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Estado Pago:";
            // 
            // cbxEstado_Pago
            // 
            this.cbxEstado_Pago.FormattingEnabled = true;
            this.cbxEstado_Pago.ItemHeight = 23;
            this.cbxEstado_Pago.Location = new System.Drawing.Point(652, 70);
            this.cbxEstado_Pago.Name = "cbxEstado_Pago";
            this.cbxEstado_Pago.Size = new System.Drawing.Size(186, 29);
            this.cbxEstado_Pago.TabIndex = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 117);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Observaciones:";
            // 
            // lbxObservacion
            // 
            this.lbxObservacion.FormattingEnabled = true;
            this.lbxObservacion.Location = new System.Drawing.Point(136, 117);
            this.lbxObservacion.Name = "lbxObservacion";
            this.lbxObservacion.Size = new System.Drawing.Size(332, 82);
            this.lbxObservacion.TabIndex = 12;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(502, 117);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Id Proveedor:";
            // 
            // txtId_Proveedor
            // 
            this.txtId_Proveedor.Location = new System.Drawing.Point(598, 113);
            this.txtId_Proveedor.Name = "txtId_Proveedor";
            this.txtId_Proveedor.Size = new System.Drawing.Size(183, 23);
            this.txtId_Proveedor.TabIndex = 14;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(502, 150);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Id Usuario:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(502, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Id Tipo:";
            // 
            // txtId_Usuario
            // 
            this.txtId_Usuario.Location = new System.Drawing.Point(598, 145);
            this.txtId_Usuario.Name = "txtId_Usuario";
            this.txtId_Usuario.Size = new System.Drawing.Size(183, 23);
            this.txtId_Usuario.TabIndex = 17;
            // 
            // cbxId_Tipo
            // 
            this.cbxId_Tipo.FormattingEnabled = true;
            this.cbxId_Tipo.ItemHeight = 23;
            this.cbxId_Tipo.Location = new System.Drawing.Point(598, 174);
            this.cbxId_Tipo.Name = "cbxId_Tipo";
            this.cbxId_Tipo.Size = new System.Drawing.Size(121, 29);
            this.cbxId_Tipo.TabIndex = 18;
            // 
            // Administra_Orden_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.cbxId_Tipo);
            this.Controls.Add(this.txtId_Usuario);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtId_Proveedor);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lbxObservacion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbxEstado_Pago);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpFecha_Emision);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId_Orden_Compra);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Administra_Orden_Compra";
            this.Text = "Administra_Orden_Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtId_Orden_Compra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFecha_Emision;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbxEstado_Pago;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox lbxObservacion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtId_Proveedor;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtId_Usuario;
        private MetroFramework.Controls.MetroComboBox cbxId_Tipo;
    }
}