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
        private void mostrarVentas()
        {
            frmVentas frm = new frmVentas();
            frm.Show();
            this.Hide();
        }

        private void mostrarProductos()
        {
            frmProductos frm = new frmProductos();
            frm.Show();
            this.Hide();
        }

        private void cerrarSesion()
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void mostrarReporteVentas()
        {
            frmReporteVentas frm = new frmReporteVentas();
            frm.Show();
            this.Hide();
        }

        private void hacerVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarReporteVentas();
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    mostrarVentas();
                    return true;
                case Keys.F2:
                    mostrarProductos();
                    return true;
                case Keys.F3:
                    mostrarReporteVentas();
                    return true;
                //case Keys.Escape:
                //    cerrarSesion();
                //    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            //if (keyData == (Keys.F1))
            //{
            //    MessageBox.Show("What the Ctrl+F?");
            //    return true;
            //}
            //return base.ProcessCmdKey(ref msg, keyData);
        }
    }
    }
