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
using ventas.modelos;

namespace ventas
{
    public partial class Form4 : Form
    {
        FacturaBL _FacturaBL;
        public Form4()
        {
            InitializeComponent();
        }

        public void cargarDatos(FacturaBL FacturaBL, ClienteBL ClientesBL, ProductoBL ProductoBL)
        {
            _FacturaBL = FacturaBL;
            listadeFacturaBindingSource.DataSource = FacturaBL.ListadeFactura;
            listadeClienteBindingSource.DataSource = ClientesBL.ListadeCliente;
            listadeProductosBindingSource.DataSource = ProductoBL.ListadeProductos;
        }

        private void facturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var Factura = (Factura)listadeFacturaBindingSource.Current;
            Factura.CalcularTotalFatura();

            listadeFacturaBindingSource.ResetBindings(false);
        }
    }

    
}
