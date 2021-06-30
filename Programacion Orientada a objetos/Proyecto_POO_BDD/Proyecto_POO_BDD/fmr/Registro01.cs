using System;
using System.IO;
using System.Windows.Forms;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.servicios;

namespace Proyecto_POO_BDD
{
    public partial class Registro01 : Form
    {
    
        public Registro01()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Ciudadano cita = new Ciudadano(
                Convert.ToInt32(txtDui.Text),
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtEnfermedad.Text,
                cmbIntitucion.Text

            );
            var db = new Banco_de_datosContext();
            db.Add(cita);
            db.SaveChanges();
            
            MessageBox.Show ("Se ha registrado exitosamente", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal window = new Principal();
            window.Show();
            this.Hide();
        }

        private void Registro01_FormClosing(object sender, FormClosingEventArgs e)
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
