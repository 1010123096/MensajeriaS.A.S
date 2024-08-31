using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Guia
    {
        private string numeroEnvio;
        private DateTime fecha;
        private Estado estado;
        private Paquete paquete;
        private Destinatario destinatario;
        private Remitente remitente;

        public Guia() { }

        public Guia(string numeroEnvio, DateTime fecha, Estado estado, Paquete paquete, Destinatario destinatario, Remitente remitente)
        {
            this.numeroEnvio = numeroEnvio;
            this.fecha = fecha;
            this.estado = estado;
            this.paquete = paquete;
            this.destinatario = destinatario;
            this.remitente = remitente;
        }
        public string ObtenerNumeroEnvio() => numeroEnvio;
        public string ObtenerNombreDestinatario() => destinatario.nombreDestinatario;
               public DateTime ObtenerFecha() => fecha;
        public Estado ObtenerEstado() => estado;
        public Paquete ObtenerPaquete() => paquete;
        public Destinatario ObtenerDestinatario() => destinatario;
       
        public Remitente ObtenerRemitente() => remitente;
    }


    
}
