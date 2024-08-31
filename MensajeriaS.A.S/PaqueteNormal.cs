using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class PaqueteNormal : Paquete
    {
        public PaqueteNormal() { }
        public PaqueteNormal(double peso, int cantidad, string descripcion, double valorDeclarado, bool dHL)
        : base(peso, cantidad, descripcion, valorDeclarado, dHL) { }
        public override double CalcularCosto()
        {
            double peso = GetPeso();
            int cantidad = GetCantidad();
            double costoEnvio = valorBase * peso;
            if (GetDHL())
            {
                costoEnvio += costoEnvio * 0.25;
            }
            
           
            return costoEnvio;
        }
    }
}
