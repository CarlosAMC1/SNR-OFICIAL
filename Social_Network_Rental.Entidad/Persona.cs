using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network_Rental.Entidad
{
    public class Persona
    {
        public int PersonaId { set; get; }

        public string Dni { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Celular { set; get; }
        public string Email { set; get; }
        public string Direccion { set; get; }

    }
}
