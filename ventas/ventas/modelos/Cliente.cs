using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas.modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public Ciudad Ciudad { get; set; }
        public int CiudadId { get; set; }

        public Cliente()
        {
            Ciudad = new Ciudad(1, "San Pedro Sula");
            CiudadId = CiudadId;
        }

        public Cliente(int id, string nombre, int telefono, Ciudad ciudad)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ciudad = ciudad;
            CiudadId = Ciudad.Id;

        }
    }
}
