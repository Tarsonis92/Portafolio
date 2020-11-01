namespace Portafolio
{
    partial class Administracion_Reservacion
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
            this.txtId_Reserva = new MetroFramework.Controls.MetroTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtId_Usuario = new MetroFramework.Controls.MetroTextBox();
            this.txtId_Mesa = new MetroFramework.Controls.MetroTextBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id Reserva:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(398, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Fecha Hora:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(101, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Id Usuario:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(398, 111);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Id Mesa:";
            // 
            // txtId_Reserva
            // 
            this.txtId_Reserva.Location = new System.Drawing.Point(184, 72);
            this.txtId_Reserva.Name = "txtId_Reserva";
            this.txtId_Reserva.Size = new System.Drawing.Size(187, 23);
            this.txtId_Reserva.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(505, 71);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtId_Usuario
            // 
            this.txtId_Usuario.Location = new System.Drawing.Point(184, 115);
            this.txtId_Usuario.Name = "txtId_Usuario";
            this.txtId_Usuario.Size = new System.Drawing.Size(187, 23);
            this.txtId_Usuario.TabIndex = 6;
            // 
            // txtId_Mesa
            // 
            this.txtId_Mesa.Location = new System.Drawing.Point(505, 111);
            this.txtId_Mesa.Name = "txtId_Mesa";
            this.txtId_Mesa.Size = new System.Drawing.Size(200, 23);
            this.txtId_Mesa.TabIndex = 7;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(133, 214);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(528, 213);
            this.dgvTabla.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(246, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(371, 171);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(496, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            // 
            // Administracion_Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.txtId_Mesa);
            this.Controls.Add(this.txtId_Usuario);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtId_Reserva);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Administracion_Reservacion";
            this.Text = "Administracion_Reservacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtId_Reserva;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MetroFramework.Controls.MetroTextBox txtId_Usuario;
        private MetroFramework.Controls.MetroTextBox txtId_Mesa;
        private System.Windows.Forms.DataGridView dgvTabla;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}