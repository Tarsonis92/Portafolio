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
            this.dtpFecha_Orden = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtId_Mesa = new MetroFramework.Controls.MetroTextBox();
            this.dtpHora_Entrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHora_Salida = new System.Windows.Forms.DateTimePicker();
            this.btnDetalle_Comanda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id Comanda:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(493, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Fecha Orden:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(59, 114);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Hora Entrada:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(383, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Hora Salida:";
            // 
            // txtId_Comanda
            // 
            this.txtId_Comanda.Location = new System.Drawing.Point(99, 73);
            this.txtId_Comanda.Name = "txtId_Comanda";
            this.txtId_Comanda.Size = new System.Drawing.Size(179, 23);
            this.txtId_Comanda.TabIndex = 4;
            // 
            // dtpFecha_Orden
            // 
            this.dtpFecha_Orden.Location = new System.Drawing.Point(584, 77);
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
            this.btnAgregar.Location = new System.Drawing.Point(127, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 54);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(245, 161);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 54);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(363, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 54);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(285, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Id Mesa:";
            // 
            // txtId_Mesa
            // 
            this.txtId_Mesa.Location = new System.Drawing.Point(346, 73);
            this.txtId_Mesa.Name = "txtId_Mesa";
            this.txtId_Mesa.Size = new System.Drawing.Size(139, 23);
            this.txtId_Mesa.TabIndex = 13;
            // 
            // dtpHora_Entrada
            // 
            this.dtpHora_Entrada.Location = new System.Drawing.Point(155, 114);
            this.dtpHora_Entrada.Name = "dtpHora_Entrada";
            this.dtpHora_Entrada.Size = new System.Drawing.Size(200, 20);
            this.dtpHora_Entrada.TabIndex = 14;
            // 
            // dtpHora_Salida
            // 
            this.dtpHora_Salida.Location = new System.Drawing.Point(469, 114);
            this.dtpHora_Salida.Name = "dtpHora_Salida";
            this.dtpHora_Salida.Size = new System.Drawing.Size(200, 20);
            this.dtpHora_Salida.TabIndex = 15;
            // 
            // btnDetalle_Comanda
            // 
            this.btnDetalle_Comanda.Location = new System.Drawing.Point(481, 161);
            this.btnDetalle_Comanda.Name = "btnDetalle_Comanda";
            this.btnDetalle_Comanda.Size = new System.Drawing.Size(168, 54);
            this.btnDetalle_Comanda.TabIndex = 16;
            this.btnDetalle_Comanda.Text = "Administrar Detalle Comanda";
            this.btnDetalle_Comanda.Click += new System.EventHandler(this.btnDetalle_Comanda_Click);
            // 
            // Administrar_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalle_Comanda);
            this.Controls.Add(this.dtpHora_Salida);
            this.Controls.Add(this.dtpHora_Entrada);
            this.Controls.Add(this.txtId_Mesa);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFecha_Orden);
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
        private System.Windows.Forms.DateTimePicker dtpFecha_Orden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtId_Mesa;
        private System.Windows.Forms.DateTimePicker dtpHora_Entrada;
        private System.Windows.Forms.DateTimePicker dtpHora_Salida;
        private MetroFramework.Controls.MetroButton btnDetalle_Comanda;
    }
}