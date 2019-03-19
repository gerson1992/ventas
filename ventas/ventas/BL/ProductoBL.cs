using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.modelos;

namespace ventas.BL
{
    public class ProductoBL
    {
        public BindingList<Productos> ListadeProductos { get; set; }

        public ProductoBL()
        {
            ListadeProductos = new BindingList<Productos>();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;
            foreach (var producto in ListadeProductos)
            {
                if (producto.Id == id)
                {
                    precio = producto.Precio;
                }

            }

            return precio;
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var productos1 = new Productos(1, "Laptop Dell", 15000, categoria1);
            var productos2 = new Productos(2, "Laptop Asus", 20000, categoria1);
            var productos3 = new Productos(3, "Mouse Logitech", 200, categoria2);

            ListadeProductos.Add(productos1);
            ListadeProductos.Add(productos2);
            ListadeProductos.Add(productos3);
        }
    }
}
