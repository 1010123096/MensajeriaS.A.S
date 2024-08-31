using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Sobre : Paquete
    {
        public Sobre() { }
       public Sobre (double peso, int cantidad, string descripcion, double valorDeclarado, bool dHL)
        : base(peso, cantidad, descripcion, valorDeclarado, dHL) { }
        
    public override double CalcularCosto()
        {
            double costoEnvio = valorBase + 10000;
            if (GetDHL())
            {
                costoEnvio += costoEnvio * 0.25;
            }
            
          return costoEnvio;
            
        }
    }
}
