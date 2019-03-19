using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.modelos;

namespace ventas.BL
{
   public class CiudadBL
    {
        public BindingList<Ciudad> ListadeCiudad { get; set; }

        public CiudadBL()
        {
            ListadeCiudad = new BindingList<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Progreso");
           

            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);
        }
    }
}
