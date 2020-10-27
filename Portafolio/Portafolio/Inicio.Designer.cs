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
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(129, 48);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(251, 156);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Location = new System.Drawing.Point(386, 48);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(251, 156);
            this.btnFinanzas.TabIndex = 1;
            this.btnFinanzas.Text = "Finanzas";
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(129, 210);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(251, 86);
            this.btnBodega.TabIndex = 2;
            this.btnBodega.Text = "Bodega";
            // 
            // btnCocina
            // 
            this.btnCocina.Location = new System.Drawing.Point(386, 210);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(251, 86);
            this.btnCocina.TabIndex = 3;
            this.btnCocina.Text = "Cocina";
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(129, 303);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(508, 81);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Recepcion";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCocina);
            this.Controls.Add(this.btnBodega);
            this.Controls.Add(this.btnFinanzas);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdmin;
        private MetroFramework.Controls.MetroButton btnFinanzas;
        private MetroFramework.Controls.MetroButton btnBodega;
        private MetroFramework.Controls.MetroButton btnCocina;
        private MetroFramework.Controls.MetroButton btnClientes;
    }
}