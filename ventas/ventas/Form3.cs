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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var ClienteBL = new ClienteBL();
            listadeClienteBindingSource.DataSource = ClienteBL.ListadeCliente;

            var CiudadBL = new CiudadBL();
            listadeCiudadBindingSource.DataSource = CiudadBL.ListadeCiudad;

        }
    }
}
