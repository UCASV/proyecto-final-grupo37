using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Proyecto_P3.SqlServerContext;
using System.IO;
using System.Data;
using System.Linq;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Proyecto_P3.Vmodels;
using Ciudadano = Proyecto_P3.Entitys.Ciudadanos.Ciudadano;

namespace Proyecto_P3
{
    public partial class Seguimiento_de_citas : Form
    {

        private bool _showformdb = false;
        public Seguimiento_de_citas()
        {
            InitializeComponent();
          
        }
        
    
        SqlConnection connection = new SqlConnection("Server=DESKTOP-D82P45T;Database=Banco_de_datos;Trusted_Connection=True;");

        private void Seguimiento_de_citas_Load(object sender, EventArgs e)     //poner datos al dgv
        {
        
            string seguimiento = "SELECT * FROM Ciudadano ";

            SqlDataAdapter adatador = new SqlDataAdapter(seguimiento, connection);

            DataTable cita = new DataTable();
            
            adatador.Fill(cita);

            
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e) //buscar cita a paritr del dui
        {
            
            
            if ((int) e.KeyChar == (int) Keys.Enter)
            {

                if (!_showformdb )
                {
                    
                  
                    List<CiudadanoVm> mappeds;
                    
                    
                    using (var context = new Banco_de_datosContext())
                    {
                        var newDbs = context.Ciudadanos1.ToList();
                        
                        

                        mappeds = new List<CiudadanoVm>();
                        List<Ciudadano1> ciudadano = newDbs.Where(a => a.Dui == txtdui.Text).ToList();
                        
                        ciudadano.ForEach(e => mappeds.Add(CiudadanoMapper.mapCiudadanotoCiudadanoVm(e)));

                        
                    }

                    dgvdatos.DataSource = mappeds ;
                }
                
                else
                {
                    MessageBox.Show("Su dui no esta registrado", "Banco_de_datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }




        private void btnpdf_Click(object sender, EventArgs e)         //creaccion del pdf
            { 
                    PdfPTable pdfTable = new PdfPTable(dgvdatos.ColumnCount);

                    
                    pdfTable.DefaultCell.Padding = 3;

                    pdfTable.WidthPercentage = 30;

                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    pdfTable.DefaultCell.BorderWidth = 1;


                    foreach (DataGridViewColumn column in dgvdatos.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        pdfTable.AddCell(cell);
                    }


                    foreach (DataGridViewRow row in dgvdatos.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }

                    string folderPath = "C:\\PDFs\\";

                    if (!Directory.Exists(folderPath))

                    {
                        Directory.CreateDirectory(folderPath);
                    }


                    using (FileStream stream = new FileStream(folderPath + "Cita.pdf", FileMode.Create))
                    {

                        Document pdfCiudadano = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfCiudadano, stream);


                        pdfCiudadano.Open();
                        pdfCiudadano.Add(pdfTable);
                        pdfCiudadano.Close();
                        stream.Close();

                    }
                
            }

        
    }
}


    
