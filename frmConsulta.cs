using System;
using System.Windows.Forms;
using Ferreteria.Objetos;
using System.Collections.Generic;

namespace Ferreteria
{
    public partial class frmConsulta : Form
    {
        private const int ID_NUM = 0;
        private const int NOMBRE_NUM = 1;
        private const int DESCRI_NUM = 2;
        private const int MENU_NUM = 3;
        private const int MAYO_NUM = 4;

        public string valor { get; set; }

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Rows.Clear();
            producto Producto = new producto();
            List<string[]> lista = Producto.busquedaProducto(txtBusqueda.Text);
            if(lista.Count != 0)
            {
                foreach (string[] elemento in lista)
                {
                    dgvBusqueda.Rows.Add(elemento[ID_NUM],elemento[NOMBRE_NUM],elemento[DESCRI_NUM],elemento[MENU_NUM], elemento[MAYO_NUM]);
                }
                dgvBusqueda.Focus();
            }
            else
            {
                MessageBox.Show("No se encontraron resultados de la búsqueda realizada", "Sin resultados",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusqueda.Text = string.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int intFila = e.RowIndex;
            seleccionar(intFila);
        }

        private void dgvBusqueda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int intFila = dgvBusqueda.CurrentRow.Index;
                seleccionar(intFila);
            }
        }

        private void seleccionar(int fila)
        {
            valor = dgvBusqueda.Rows[fila].Cells[ID_NUM].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
