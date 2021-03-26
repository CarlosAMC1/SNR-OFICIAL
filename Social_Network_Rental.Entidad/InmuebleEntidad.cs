using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network_Rental.Entidad
{
    public class InmuebleEntidad
    {
        public int idusuario { get; set; }
        public int idinmueble { get; set; }
        public string Direccion { get; set; }
        public string NumeroH { get; set; }
        public string Ciudad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Precio { get; set; }
        public byte[] Imagen { get; set; }
    }
}
