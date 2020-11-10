using System;

namespace TestDrivenPractice
{
    public class CalculadorImpuestos
    {
        //16%
        private const decimal iva = .16M;
        public CalculadorImpuestos()
        {

        }

        public decimal GetIva(decimal monto)
        {
            return iva * monto;
        }

        public decimal GetISH(decimal monto, decimal porcentaje)
        {
            return monto * porcentaje;
        }

        public decimal GetMontoTotal(decimal monto, decimal porcentaje)
        {
            return GetIva(monto) + GetISH(monto, porcentaje);
        }
    }
}