using System;

namespace PrimerParcial
{
    /*====================================================================
     * INTERFAZ: IVehiculo
     * - Define el contrato que deben cumplir todos los vehículos.
     * - Métodos: Encender() y Apagar()
     * - Las clases que implementen esta interfaz DEBEN definir
     *   la implementación de estos métodos.
     * 
     * Ejercicio 7: Interfaces y Abstracción
     =====================================================================*/
    public interface IVehiculo
    {
        // Método para encender el vehículo
        void Encender();

        // Método para apagar el vehículo
        void Apagar();

        // Propiedad para obtener el estado del vehículo
        bool EstaEncendido { get; }
    }

    /*====================================================================
     * CLASE: Carro (implementa IVehiculo)
     * - Implementa todos los métodos de la interfaz IVehiculo.
     * - Muestra mensajes específicos para un carro.
     =====================================================================*/
    public class Carro : IVehiculo
    {
        // Propiedad para almacenar la marca del carro
        public string Marca { get; set; }

        // Propiedad para almacenar el modelo del carro
        public string Modelo { get; set; }

        // Campo privado para el estado del motor
        private bool estaEncendido;

        // Implementación de la propiedad de la interfaz
        public bool EstaEncendido => estaEncendido;

        // Constructor
        public Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            estaEncendido = false;
        }

        /*====================================================================
         * IMPLEMENTACIÓN: Encender()
         * - Simula encender el carro con efectos visuales.
         =====================================================================*/
        public void Encender()
        {
            if (!estaEncendido)
            {
                estaEncendido = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"      El carro {Marca} {Modelo} está encendiendo...");
                Console.WriteLine("      *Girando la llave*");
                Console.WriteLine("      ¡VROOM VROOM!");
                Console.WriteLine("      Listo para conducir.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("      El carro ya está encendido.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /*====================================================================
         * IMPLEMENTACIÓN: Apagar()
         * - Simula apagar el carro con efectos visuales.
         =====================================================================*/
        public void Apagar()
        {
            if (estaEncendido)
            {
                estaEncendido = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"     Apagando el carro {Marca} {Modelo}...");
                Console.WriteLine("      Girando la llave a posición OFF*");
                Console.WriteLine("      uuuuug");
                Console.WriteLine("      El carro está APAGADO.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("      El carro ya está apagado.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    /*====================================================================
     * CLASE: Motocicleta (implementa IVehiculo)
     * - Implementa todos los métodos de la interfaz IVehiculo.
     * - Muestra mensajes específicos para una motocicleta.
     =====================================================================*/
    public class Motocicleta : IVehiculo
    {
        // Propiedad para almacenar la marca
        public string Marca { get; set; }

        // Propiedad para almacenar los cilindros (cc)
        public int Cilindrada { get; set; }

        // Campo privado para el estado del motor
        private bool estaEncendido;

        // Implementación de la propiedad de la interfaz
        public bool EstaEncendido => estaEncendido;

        // Constructor
        public Motocicleta(string marca, int cilindrada)
        {
            Marca = marca;
            Cilindrada = cilindrada;
            estaEncendido = false;
        }

        /*====================================================================
         * IMPLEMENTACIÓN: Encender()
         * - Simula encender la motocicleta con efectos visuales.
         =====================================================================*/
        public void Encender()
        {
            if (!estaEncendido)
            {
                estaEncendido = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"      La motocicleta {Marca} de {Cilindrada}cc está encendiendo...");
                Console.WriteLine("       Presionando el botón de arranque");
                Console.WriteLine("       ¡BRRRRR!");
                Console.WriteLine("       60 K/h");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("       La motocicleta ya está encendida.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /*====================================================================
         * IMPLEMENTACIÓN: Apagar()
         * - Simula apagar la motocicleta con efectos visuales.
         =====================================================================*/
        public void Apagar()
        {
            if (estaEncendido)
            {
                estaEncendido = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"      Apagando la motocicleta {Marca}...");
                Console.WriteLine("       Girando la llave a OFF*");
                Console.WriteLine("       ...");
                Console.WriteLine("       La motocicleta está APAGADA.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("       La motocicleta ya está apagada.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
