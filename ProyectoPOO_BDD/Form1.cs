using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPOO_BDD.DataContext;

namespace ProyectoPOO_BDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Ciudadano cita = new Ciudadano(
                Convert.ToInt32(txtDui.Text),
                txtNombre.Text,
                txtDireccionDomicilio.Text,
                txtTelefono.Text,
                txtCorreoElectronico.Text,
                txtEnfermedad.Text,
                ComboInstitucion.Text);
            
            // se crea validacion por si el usuario no llena todos los espacios
            if (txtDui.Text.Length == 0){
                MessageBox.Show ("Llenar todos los espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
            else if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show ("Llenar todos los espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }
            else if (txtDireccionDomicilio.Text.Length == 0)
            {
                MessageBox.Show ("LLenar todos los espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show ("Llenar todos lo espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (txtCorreoElectronico.Text.Length == 0)
            {
                MessageBox.Show ("Llenar todos los espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (txtEnfermedad.Text.Length == 0)
            {
                MessageBox.Show ("Llenar todos los espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (ComboInstitucion.Text.Length == 0)
            {
                MessageBox.Show ("Llenar todos los espacios", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            // si el usuario llenó los espacios solicitados, se guardaran los datos en la base de datos
            else
            {
                var db = new Banco_de_datossContext();
                db.Add(cita);
                db.SaveChanges();
                MessageBox.Show ("Se ha registrado exitosamente ", "Registro de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}