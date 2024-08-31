using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaS.A.S
{
    public abstract class Paquete
    {
        private double peso;
        private int cantidad;
        private string descripcion;
        private double valorDeclarado;
        protected int valorBase = 5000;
        private Boolean DHL;

        public Paquete() { }
        public Paquete(double peso, int cantidad, string descripcion, double valorDeclarado, bool dHL)
        {
            this.peso = peso;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.valorDeclarado = valorDeclarado;
            this.DHL = dHL;
        }
        public double GetPeso() => peso;
        public void SetPeso(double value) => peso = value;

        public int GetCantidad() => cantidad;
        public void SetCantidad(int value) => cantidad = value;

        public string GetDescripcion() => descripcion;
        public void SetDescripcion(string value) => descripcion = value;

        public double GetValorDeclarado() => valorDeclarado;
        public void SetValorDeclarado(double value) => valorDeclarado = value;

        public bool GetDHL() => DHL;
        public void SetDHL(bool value) => DHL = value;

       
        public abstract double CalcularCosto();
        public string ObtenerInformacionCompleta()
        {
            return $"Peso: {GetPeso()} kg\n" +
                   $"Cantidad: {GetCantidad()}\n" +
                   $"Descripción: {GetDescripcion()}\n" +
                   $"Valor Declarado: {GetValorDeclarado():C}\n" +
                   $"Enviado por DHL: {GetDHL()}\n" +
                   $"Costo Total: {CalcularCosto():C}";
        }
    }
}
