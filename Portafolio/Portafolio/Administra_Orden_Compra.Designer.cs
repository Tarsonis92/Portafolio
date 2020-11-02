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
            this.txtId_Orden = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.dtpFecha_Emision = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxEstado_Pago = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbxObservacion = new System.Windows.Forms.ListBox();
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
            // txtId_Orden
            // 
            this.txtId_Orden.Location = new System.Drawing.Point(96, 65);
            this.txtId_Orden.Name = "txtId_Orden";
            this.txtId_Orden.Size = new System.Drawing.Size(151, 23);
            this.txtId_Orden.TabIndex = 2;
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
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(354, 209);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 51);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(502, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 51);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
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
            this.lbxObservacion.Size = new System.Drawing.Size(675, 82);
            this.lbxObservacion.TabIndex = 12;
            // 
            // Administra_Orden_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.lbxObservacion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbxEstado_Pago);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtpFecha_Emision);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId_Orden);
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
        private MetroFramework.Controls.MetroTextBox txtId_Orden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFecha_Emision;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbxEstado_Pago;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox lbxObservacion;
    }
}