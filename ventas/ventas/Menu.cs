using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;

namespace ventas
{
    public partial class Menu : Form
    {
        ProductoBL _productosBL;
        CategoriasBL _CategoriaBL;
        ClienteBL _ClientesBL;
        CiudadBL _CiudadBL;
        FacturaBL _FacturaBL;
        public Menu()
        {
            InitializeComponent();

            _productosBL = new ProductoBL();
            _CategoriaBL = new CategoriasBL();
            _ClientesBL = new ClienteBL();
            _CiudadBL = new CiudadBL();
            _FacturaBL = new FacturaBL();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form2();
            formProductos.MdiParent = this;
            formProductos.Show();

            formProductos.cargarDatos(_productosBL, _CategoriaBL);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form3();
            formClientes.MdiParent = this;
            formClientes.Show();

            formClientes.cargarDatos(_ClientesBL, _CiudadBL);
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form4();
            formFactura.MdiParent = this;

            formFactura.cargarDatos(_FacturaBL, _ClientesBL, _productosBL);

            formFactura.Show();

        }
    }
}
