using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Carta_Presentacion : MetroFramework.Forms.MetroForm
    {
        public Carta_Presentacion()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.Show();
        }

        private void btnFondos_Click(object sender, EventArgs e)
        {
            Fondos fondos = new Fondos();
            fondos.Show();
        }

        private void btnSopas_Click(object sender, EventArgs e)
        {
            Sopas sopas = new Sopas();
            sopas.Show();
        }

        private void btnEnsaladas_Click(object sender, EventArgs e)
        {
            Ensalada ensalada = new Ensalada();
            ensalada.Show();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            Postres postres = new Postres();
            postres.Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Bebidas bebidas = new Bebidas();
            bebidas.Show();
        }

        private void btnJugos_Naturales_Click(object sender, EventArgs e)
        {
            Jugos_Naturales jugos = new Jugos_Naturales();
            jugos.Show();
        }

        private void btnBocadillos_Click(object sender, EventArgs e)
        {
            Bocadillos bocadillos = new Bocadillos();
            bocadillos.Show();
        }

        private void btnAdhereso_Click(object sender, EventArgs e)
        {
            Adhereso adhereso = new Adhereso();
            adhereso.Show();
        }

        private void btnSandwich_Hamburgesas_Click(object sender, EventArgs e)
        {
            Sandwich_Hamburgesas sandwich = new Sandwich_Hamburgesas();
            sandwich.Show();
        }
    }
}
