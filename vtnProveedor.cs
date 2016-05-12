using Ferreteria.Objetos;
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
    public partial class vtnProveedor : Form
    {
        private const int ID_NUM = 0;
        private const int NOMBRE_NUM = 1;

        public string valor { get; set; }

        public vtnProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBusqueda.Rows.Clear();
            proveedor Proveedor = new proveedor();
            List<string[]> lista = Proveedor.busqueda(txtBusqueda.Text);
            if (lista.Count != 0)
            {
                foreach (string[] elemento in lista)
                {
                    dgvBusqueda.Rows.Add(elemento[ID_NUM], elemento[NOMBRE_NUM]);
                }
                dgvBusqueda.Focus();
            }
            else
            {
                MessageBox.Show("No se encontraron resultados de la búsqueda realizada", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvBusqueda.Rows[fila].Cells[ID_NUM].Value != null)
            {
                valor = dgvBusqueda.Rows[fila].Cells[ID_NUM].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
