using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public class Caja : Paquete
    {
        private double volumenCaja;
        private double tarifa=2500;
        public Caja() { }
        public Caja(double peso, int cantidad, string descripcion, double valorDeclarado, bool dHL,double voCaja)
         : base(peso, cantidad, descripcion, valorDeclarado, dHL) {
           this.volumenCaja = voCaja;
        }
               
        public override double CalcularCosto()
        {
            double peso = GetPeso();
            tarifa += tarifa * volumenCaja;
            double costoEnvio = (valorBase * peso)+tarifa;
            if (GetDHL())
            {
                return costoEnvio += costoEnvio * 0.25;
            }
            return costoEnvio;
        }
    }
}
