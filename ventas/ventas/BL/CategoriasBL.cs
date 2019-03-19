using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.modelos;

namespace ventas.BL
{
   public class CategoriasBL
    {
        public BindingList<Categoria> Listadecategorias { get; set; }

        public CategoriasBL()
        {
            Listadecategorias = new BindingList<Categoria>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            Listadecategorias.Add(categoria1);
            Listadecategorias.Add(categoria2);
        }
    }

   
}
