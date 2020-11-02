namespace Portafolio
{
    partial class Administrar_Comanda
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtId_Comanda = new MetroFramework.Controls.MetroTextBox();
            this.txtHora_Salida = new MetroFramework.Controls.MetroTextBox();
            this.txtHora_Orden = new MetroFramework.Controls.MetroTextBox();
            this.dtpFecha_Orden = new System.Windows.Forms.DateTimePicker();
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
            this.metroLabel1.Location = new System.Drawing.Point(73, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id Comanda:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(375, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Fecha Orden:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Hora Entrada:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(383, 116);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Hora Salida:";
            // 
            // txtId_Comanda
            // 
            this.txtId_Comanda.Location = new System.Drawing.Point(164, 74);
            this.txtId_Comanda.Name = "txtId_Comanda";
            this.txtId_Comanda.Size = new System.Drawing.Size(179, 23);
            this.txtId_Comanda.TabIndex = 4;
            // 
            // txtHora_Salida
            // 
            this.txtHora_Salida.Location = new System.Drawing.Point(469, 116);
            this.txtHora_Salida.Name = "txtHora_Salida";
            this.txtHora_Salida.Size = new System.Drawing.Size(200, 23);
            this.txtHora_Salida.TabIndex = 5;
            // 
            // txtHora_Orden
            // 
            this.txtHora_Orden.Location = new System.Drawing.Point(169, 116);
            this.txtHora_Orden.Name = "txtHora_Orden";
            this.txtHora_Orden.Size = new System.Drawing.Size(174, 23);
            this.txtHora_Orden.TabIndex = 6;
            // 
            // dtpFecha_Orden
            // 
            this.dtpFecha_Orden.Location = new System.Drawing.Point(469, 78);
            this.dtpFecha_Orden.Name = "dtpFecha_Orden";
            this.dtpFecha_Orden.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Orden.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 206);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(215, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 54);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(333, 161);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 54);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(451, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 54);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            // 
            // Administrar_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFecha_Orden);
            this.Controls.Add(this.txtHora_Orden);
            this.Controls.Add(this.txtHora_Salida);
            this.Controls.Add(this.txtId_Comanda);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Administrar_Comanda";
            this.Text = "Administrar_Comanda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtId_Comanda;
        private MetroFramework.Controls.MetroTextBox txtHora_Salida;
        private MetroFramework.Controls.MetroTextBox txtHora_Orden;
        private System.Windows.Forms.DateTimePicker dtpFecha_Orden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}