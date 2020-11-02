namespace Portafolio
{
    partial class Inicio
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
            this.btnAdmin = new MetroFramework.Controls.MetroButton();
            this.btnFinanzas = new MetroFramework.Controls.MetroButton();
            this.btnBodega = new MetroFramework.Controls.MetroButton();
            this.btnCocina = new MetroFramework.Controls.MetroButton();
            this.btnClientes = new MetroFramework.Controls.MetroButton();
            this.btnAdministrar_Carta = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(217, 268);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(199, 116);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Location = new System.Drawing.Point(422, 24);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(199, 116);
            this.btnFinanzas.TabIndex = 1;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(422, 146);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(199, 116);
            this.btnBodega.TabIndex = 2;
            this.btnBodega.Text = "Bodega";
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // btnCocina
            // 
            this.btnCocina.Location = new System.Drawing.Point(217, 24);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(199, 116);
            this.btnCocina.TabIndex = 3;
            this.btnCocina.Text = "Cocina";
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(217, 146);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(199, 116);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Recepcion";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnAdministrar_Carta
            // 
            this.btnAdministrar_Carta.Location = new System.Drawing.Point(423, 269);
            this.btnAdministrar_Carta.Name = "btnAdministrar_Carta";
            this.btnAdministrar_Carta.Size = new System.Drawing.Size(198, 115);
            this.btnAdministrar_Carta.TabIndex = 5;
            this.btnAdministrar_Carta.Text = "Administrar Carta";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdministrar_Carta);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCocina);
            this.Controls.Add(this.btnBodega);
            this.Controls.Add(this.btnFinanzas);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdmin;
        private MetroFramework.Controls.MetroButton btnFinanzas;
        private MetroFramework.Controls.MetroButton btnBodega;
        private MetroFramework.Controls.MetroButton btnCocina;
        private MetroFramework.Controls.MetroButton btnClientes;
        private MetroFramework.Controls.MetroButton btnAdministrar_Carta;
    }
}