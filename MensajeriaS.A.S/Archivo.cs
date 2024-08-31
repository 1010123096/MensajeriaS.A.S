using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Archivo
    {
        private List<Guia> guias;

        public Archivo()
        {
            guias = new List<Guia>();
        }
        public void agregarGuia(Guia guia)
        {
            if (guia != null)
            {
                guias.Add(guia);
            }
            else
            {
                throw new ArgumentNullException(nameof(guia), "La guía no puede ser nula.");
            }
        }
        public Guia consultarGuiaPorNumero(string numero)
        {
                if (string.IsNullOrEmpty(numero))
                {
                    throw new ArgumentException("El número de envío no puede estar vacío o nulo.", nameof(numero));
                }
            return guias.FirstOrDefault(g => g.ObtenerNumeroEnvio() == numero);
        }
        public List<Guia> consultarGuiaPorDestinatario(string nombreDestinatario) {
            if (string.IsNullOrEmpty(nombreDestinatario))
            {
                throw new ArgumentException("El nombre del destinatario no puede estar vacío o nulo.", nameof(nombreDestinatario));
            }

            return guias.Where(g => g.ObtenerNombreDestinatario() == nombreDestinatario).ToList();
        }
    }
}
