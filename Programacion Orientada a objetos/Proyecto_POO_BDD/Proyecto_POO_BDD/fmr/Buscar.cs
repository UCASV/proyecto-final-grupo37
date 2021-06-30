using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.viewModel;
using Proyecto_POO_BDD.servicios;


namespace Proyecto_POO_BDD
{
    public partial class Buscar : Form
    {
        private ServiCiudadano ciudadano;
        private ServiCitas _citas;
        private ServiEmpleado _empleado;
       
        public Buscar()
        {
            InitializeComponent();
            ciudadano = new ServiCiudadano();
            _citas = new ServiCitas();
            _empleado = new ServiEmpleado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var ListCitizens = ciudadano.GetAll();
            List<Ciudadano> VerifyCitizen = ListCitizens.Where(c => c.Dui == Convert.ToUInt32(txtBuscar.Text)).ToList();

            if(VerifyCitizen.Count == 1)
            {
                MessageBox.Show("Este  ciudadano  fue vacunado!", "Empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var ListAppointments = _citas.GetAll();
                List<Citum> GetAppointment = ListAppointments.Where(a => a.IdentificadorCita == Convert.ToUInt32(txtBuscar.Text)).ToList();
                CreatePDF(GetAppointment[0], VerifyCitizen[0]);
                MessageBox.Show("Su comprobante esta listo " + VerifyCitizen[0].Nombre, "empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
        private void Buscar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Principal window = new Principal();
            window.Show();
            this.Hide();
        }
        private void CreatePDF(Citum cita, Ciudadano ciudadano)
        {
            var ListManagers = _empleado.GetAll();
            List<Empleado> getEmpleados = ListManagers.Where(m => m.IdIdentificador == cita.IdIdentificador).ToList();

            PdfWriter pdfwriter = new PdfWriter("informe");
            PdfDocument pdf = new PdfDocument(pdfwriter);
            Document document = new Document(pdf, PageSize.LETTER);

            document.SetMargins(60, 20, 55, 20);

            PdfFont fontColumns = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLDITALIC);
            PdfFont fontContent = PdfFontFactory.CreateFont(StandardFonts.TIMES_ITALIC);

            string[] columns = {  "Ciudadano" };
            float[] sizes = { 2 };
            Table table = new Table(UnitValue.CreatePercentArray(sizes));
            table.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string column in columns)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(column).SetFont(fontColumns)));
            }
            table.AddCell(new Cell().Add(new Paragraph(ciudadano.Nombre).SetFont(fontContent)));
            
            
            document.Add(table);
            document.Close();

            var title = new Paragraph("Ciudadano. Informe de Cita");
            title.SetTextAlignment(TextAlignment.CENTER);
            title.SetFontSize(14);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Informe.pdf"), new PdfWriter
                ("Informe_" + ciudadano.Dui + ".pdf"));
            Document doc = new Document(pdfDoc);

            doc.ShowTextAligned(title,200, pdfDoc.GetPage(1).GetPageSize().GetTop() - 15, 1, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            doc.Close();
        }
    }
}