using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.BL;
using ventas.modelos;

namespace ventas.BL
{
    public class ClienteBL
    {
        public BindingList<Cliente> ListadeCliente { get; set; }

        public ClienteBL()
        {
            ListadeCliente = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Progreso");

            var cliente1 = new Cliente(1, "Gerson Diaz", 32422155, ciudad2);
            var cliente2 = new Cliente(2, "Ruth Fabiola Grande", 97458562, ciudad1);
            var cliente3 = new Cliente(3, "Jafeth Diaz Grande", 32422155, ciudad1);


            ListadeCliente.Add(cliente1);
            ListadeCliente.Add(cliente2);
            ListadeCliente.Add(cliente3);
        }
    }
}
