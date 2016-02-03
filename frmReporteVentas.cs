using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmReporteVentas : Ferreteria.frmMenu
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSetVentas.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.ferreteriaDataSetVentas.ventas);

        }
    }
}
