using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.modelos;
using ventas.BL;

namespace ventas
{
    public partial class Form2 : Form
       {
        public Form2()
        {
            InitializeComponent();

            var productoBL = new ProductoBL();
            listadeProductosBindingSource.DataSource = productoBL.ListadeProductos;

            var CategoriasBL = new CategoriasBL();
            listadecategoriasBindingSource.DataSource = CategoriasBL.Listadecategorias;

        }

    }
}
