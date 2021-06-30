using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO_BDD.NombreDirectorio;

namespace Proyecto_POO_BDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = textcontra.Text;
            var db = new Banco_de_datosContext();
            var listEmpleados = db.Empleados
                .OrderBy(empleado => empleado.IdIdentificador)
                .ToList();
            var result = listEmpleados.Where(
                c => c.Usuario.Equals(txtUsuario.Text) &&
                            c.Contasena.Equals(textcontra.Text)
            ).ToList();
            if (result.Count( )== 0)
                MessageBox.Show("No se encontro su usario vuelva a intentar o registre una cuenta","Sistema de vacunacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("Bienvenido","Empleado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Principal window = new Principal();
                window.Show();
                this.Hide();
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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