using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Proyecto_POO_BDD.NombreDirectorio;
using Proyecto_POO_BDD.viewModel;

namespace Proyecto_POO_BDD
{
    public partial class Buscar : Form
    {
        private bool _showfromdb = false;
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = null;

            if (!_showfromdb )
            {
                using (var  context = new  Banco_de_datosContext())
                {
                    var newDbs = context.Ciudadanos.ToList();
                    var maperdbs = new List<CiudadanoVm>();
                    
                    newDbs.ForEach(e=> maperdbs.Add(ciudadMapper.mapedCiudadanoVm(e))) ;

                    dgvBuscar.DataSource = maperdbs;
                }
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
    }
}