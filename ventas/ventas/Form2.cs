using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ciudad1 = new ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro Sula";

            ciudad ciudad2 = new ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Progreso";

            var cliente1 = new cliente();
            cliente1.Id = 1;
            cliente1.nombre = "Gerson Josue Diaz";
            cliente1.telefono = 32422155;
            cliente1.ciudad = ciudad1;

            cliente cliente2 = new cliente();
            cliente2.Id = 2;
            cliente2.nombre = "Ruth Fabiola Grande";
            cliente2.telefono = 94724587;
            cliente2.ciudad = ciudad2;

            cliente cliente3 = new cliente();
            cliente3.Id = 3;
            cliente3.nombre = "Jafeth Diaz";
            cliente3.telefono = 94724588;
            cliente3.ciudad = ciudad2;

            var listadeClientes = new List<cliente>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);

            foreach (var c in listadeClientes)
            {
                MessageBox.Show(c.nombre + "  " + c.ciudad.Descripcion);
            }

           


        }
    }
}
