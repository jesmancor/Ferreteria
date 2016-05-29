using System;
using System.Windows.Forms;
using Ferreteria.Objetos;

namespace Ferreteria
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(cerrar);
        }

        private void cerrar(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void mostrarVentas()
        {
            frmVentas frm = new frmVentas();
            frm.Show();
            this.Dispose();
        }

        private void mostrarProductos()
        {
            frmProductos frm = new frmProductos();
            frm.Show();
            this.Dispose();
        }

        private void cerrarSesion()
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Dispose();
        }

        private void mostrarReporteVentas()
        {
            frmReporteVentas frm = new frmReporteVentas();
            frm.Show();
            this.Dispose();
        }

        private void mostrarUsuarios()
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
            this.Dispose();
        }

        private void mostrarExistencias()
        {
            frmExistencias frm = new frmExistencias();
            frm.Show();
            this.Dispose();
        }

        private void mostrarProveedores()
        {
            frmProveedores frm = new frmProveedores();
            frm.Show();
            this.Dispose();
        }

        private void mostrarProvProd()
        {
            frmProvProd frm = new frmProvProd();
            frm.Show();
            this.Dispose();
        }

        private void hacerVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarReporteVentas();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mostrarProveedores();
        }

        private void agregarExistenciasAlInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarExistencias();
        }

        private void añadirModificarYEliminarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        private void asignarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarProvProd();
        }

        private void bloquearCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void cierreDeDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool cierra = sistema.cierreDeDia();
            if (cierra)
                cerrarSesion();      
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
                case Keys.F4:
                    mostrarUsuarios();
                    return true;                
                //case Keys.Escape:
                //    cerrarSesion();
                //    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
