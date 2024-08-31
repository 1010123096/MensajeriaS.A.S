using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Destinatario
    {
        private string compania;
        public string nombreDestinatario { get; private set; }
        private Direccion direccion;
        private string telefono;
        private string nombreDestinatario1;

        public Destinatario() { }

        public Destinatario(string compania, string nombreDestinatario, Direccion direccion, string telefono)
        {
            this.compania = compania;
            this.nombreDestinatario = nombreDestinatario;
            this.direccion = direccion;
            this.telefono = telefono;
        }
       
    }
}
