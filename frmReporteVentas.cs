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
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet1.VENTAS' Puede moverla o quitarla según sea necesario.
            this.vENTASTableAdapter.Fill(this.ferreteriaDataSet1.VENTAS);

        }
    }
}
