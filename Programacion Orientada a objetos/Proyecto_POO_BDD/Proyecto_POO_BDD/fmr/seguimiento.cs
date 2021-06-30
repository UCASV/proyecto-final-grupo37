using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iText.Layout.Element;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.servicios;
using Proyecto_POO_BDD.viewModel;

namespace Proyecto_POO_BDD
{
    public partial class seguimiento : Form
    {
        private bool _showfromdb = false;
        public Empleado Empleado { get; set; }
        private ServiCiudadano ciudadano;
        private ServiEfectos _efectos;
        private ServiCitas citas;
        private ServiciudadanoXVacunacion vacunacion;
        private ServiCabina cabina;


        public seguimiento()
        {
            InitializeComponent();
            ciudadano= new ServiCiudadano();
            _efectos = new ServiEfectos();
            citas = new ServiCitas();
            vacunacion = new ServiciudadanoXVacunacion();
            cabina = new ServiCabina();
            this.Empleado = Empleado;
        }


        private void BtnSeguir_Click(object sender, EventArgs e)
        {
            {
                var listCiudadanos = ciudadano.GetAll();
                List<Ciudadano> confirm = listCiudadanos.Where(c => c.Dui == Convert.ToUInt32(txtDui.Text)).ToList();

                var Listcita = citas.GetAll();
                List<Citum> confirma = Listcita
                    .Where(a => a.IdCita == 2 && a.IdIdentificador == Convert.ToUInt32(txtDui.Text)).ToList();


                if (confirm.Count == 0)
                {
                    MessageBox.Show("Este DUI de ciudadano no esta registrado!", "Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(confirma.Count >0)
                {
                    MessageBox.Show("Este ciudadano ya ha sido vacunado!", "Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ingresando a " + confirm[0].Nombre, "Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgbBuscar.DataSource = null;

            if (!_showfromdb)
            {
                using (var context = new Banco_de_datosContext())
                {
                    var newDbs = context.Ciudadanos.ToList();
                    var maperdbs = new List<CiudadanoVm>();

                    newDbs.ForEach(e => maperdbs.Add(ciudadMapper.mapedCiudadanoVm(e)));

                    dgbBuscar.DataSource = maperdbs;
                }
            }
        }

        private void seguimiento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal window = new Principal();
            window.Show();
            this.Hide();
        }
    }
}