using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Remitente
    {
        private string nombreRemitente;
        private string departamento;
        private string telenofo;
        public Remitente() { }

        public Remitente(string nombreRemitente, string departamento, string telenofo)
        {
            this.nombreRemitente = nombreRemitente;
            this.departamento = departamento;
            this.telenofo = telenofo;
        }
        public string GetNombre() => nombreRemitente;
    }
}
