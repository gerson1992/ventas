using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.BL;

namespace ventas.modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<FactuaDetalle> FacturaDetalle { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FactuaDetalle>();
        }

        public void CalcularTotalFatura()
        {
            var productoBL = new ProductoBL();

            double subtotal = 0;
            foreach (var detalle in FacturaDetalle)
            {
                var precio = productoBL.ObtenerPrecio(detalle.ProductoId);
                subtotal = subtotal + detalle.CalcularTotalDetalle(precio);
            }

            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15;
            Total = Subtotal + Impuesto;

        }

    }

    public class FactuaDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Productos Productos { get; set; }

        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public FactuaDetalle()
        {
            Cantidad = 1;
            ProductoId = 1;
        }

        public double CalcularTotalDetalle(double precio)
        {
            Precio = precio;
            Total = Cantidad * Precio;
            return Total;
        }
    }
}
