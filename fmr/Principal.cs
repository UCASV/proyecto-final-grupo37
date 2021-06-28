using System;
using System.Windows.Forms;
using Proyecto_POO_BDD.NombreDirectorio;

namespace Proyecto_POO_BDD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnVacunacion_Click(object sender, EventArgs e)
        {
            Registro01 window = new Registro01();
              window.Show();
              this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Buscar window = new Buscar();
            window.Show();
            this.Hide();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
                "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}