using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void hacerVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentas frm = new frmReporteVentas();
            frm.Show();
            this.Hide();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyuda frm = new frmAyuda();
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            reloj.Start();
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
    }
