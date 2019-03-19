using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.modelos;

namespace ventas.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListadeFactura { get; set; }

        public FacturaBL()
        {
            ListadeFactura = new BindingList<Factura>();
        }
    }
}
