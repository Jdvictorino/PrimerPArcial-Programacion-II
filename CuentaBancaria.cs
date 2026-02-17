using System;

namespace PrimerParcial
{
    /// <summary>
    /// Clase CuentaBancaria que demuestra encapsulamiento.
    /// Ejercicio 6: Encapsulamiento
    /// </summary>
    public class CuentaBancaria
    {
        /*====================================================================
         * ATRIBUTO PRIVADO: saldo
         * - Solo accesible dentro de esta clase.
         * - Protege la integridad de los datos.
         * - No puede ser modificado directamente desde fuera.
         =====================================================================*/
        private decimal saldo;

        // Propiedad pública para el titular de la cuenta
        public string Titular { get; private set; }

        // Propiedad pública para el número de cuenta
        public string NumeroCuenta { get; private set; }

        /*====================================================================
         * CONSTRUCTOR:
         * - Inicializa la cuenta con un titular y saldo inicial de 0.
         =====================================================================*/
        public CuentaBancaria(string titular, string numeroCuenta)
        {
            Titular = titular;
            NumeroCuenta = numeroCuenta;
            saldo = 15326258.00m; // Saldo inicial es 15,326,258.00
        }

        /*====================================================================
         * MÉTODO: Depositar(decimal monto)
         * - Permite agregar dinero a la cuenta.
         * - Valida que el monto sea positivo.
         * - Actualiza el saldo privado de forma controlada.
         =====================================================================*/
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"      Depósito exitoso de ${monto:N2}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("      Error: El monto debe ser mayor a cero.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /*====================================================================
         * MÉTODO: ObtenerSaldo()
         * - Muestra el saldo actual de la cuenta.
         * - Es la única forma de acceder al saldo privado.
         =====================================================================*/
        public void ObtenerSaldo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine($"      INFORMACIÓN DE LA CUENTA");
            Console.WriteLine($"      Titular: {Titular}");
            Console.WriteLine($"      Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"      Saldo actual: ${saldo:N2}");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*====================================================================
         * MÉTODO: ConsultarSaldo()
         * - Retorna el valor del saldo (para uso interno si es necesario).
         =====================================================================*/
        public decimal ConsultarSaldo()
        {
            return saldo;
        }
    }
}
