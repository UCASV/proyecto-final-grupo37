using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using Proyecto_POO_BDD.NombreDirectorio;

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
            
            using (SaveFileDialog sfd = new SaveFileDialog(){Filter = "pdf file|*.pdf",ValidateNames = true})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
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
