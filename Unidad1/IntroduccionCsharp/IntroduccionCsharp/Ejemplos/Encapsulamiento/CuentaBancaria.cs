using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos.Encapsulamiento
{
    public class CuentaBancaria
    {
        private decimal Saldo { get; set; }

        public CuentaBancaria (decimal saldoInicial) 
        {
            Saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad) 
        {
            if (cantidad > 0)
            {
                Saldo += cantidad; // Saldo = saldo + cantidad

            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva.");
            }
        }

        public void Retirar(decimal cantidad) 
        {
            if (cantidad > 0 && cantidad <= Saldo)
            {
                Saldo -= cantidad; // Saldo = saldo - cantidad
            }
            else
            {
                Console.WriteLine("Cantidad insuficiente para retirar");
            }
        }

        public decimal ObtenerSaldo() 
        {
            return Saldo;
        }
    }
}
