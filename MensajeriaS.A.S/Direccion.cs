using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Direccion
    {
        private string calle;
        private string ciudad;
        private string municipio;
        private string estado;
        private string pais;
        private string codigoPostal;

        public Direccion() { }
        public Direccion(string calle, string ciudad, string municipio, string estado, string pais, string codigoPostal)
        {
            this.calle = calle;
            this.ciudad = ciudad;
            this.municipio = municipio;
            this.estado = estado;
            this.pais = pais;
            this.codigoPostal = codigoPostal;
        }
    }
}
