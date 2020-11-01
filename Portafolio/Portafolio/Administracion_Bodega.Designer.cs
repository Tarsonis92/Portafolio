namespace Portafolio
{
    partial class Administracion_Bodega
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtId_Bodega = new MetroFramework.Controls.MetroTextBox();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.txtId_Registro = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id_Bodega:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(306, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Stock:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(528, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Id_Registro:";
            // 
            // txtId_Bodega
            // 
            this.txtId_Bodega.Location = new System.Drawing.Point(125, 71);
            this.txtId_Bodega.Name = "txtId_Bodega";
            this.txtId_Bodega.Size = new System.Drawing.Size(159, 23);
            this.txtId_Bodega.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(355, 71);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(159, 23);
            this.txtStock.TabIndex = 4;
            // 
            // txtId_Registro
            // 
            this.txtId_Registro.Location = new System.Drawing.Point(611, 75);
            this.txtId_Registro.Name = "txtId_Registro";
            this.txtId_Registro.Size = new System.Drawing.Size(159, 23);
            this.txtId_Registro.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 242);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(230, 122);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(331, 122);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(439, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            // 
            // Administracion_Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId_Registro);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtId_Bodega);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Administracion_Bodega";
            this.Text = "Administracion_Bodega";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtId_Bodega;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroTextBox txtId_Registro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}