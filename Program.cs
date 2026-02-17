/*====================================================================
 * PROYECTO: Primer Parcial - Programacion II
 * Creado por: Juan Victorino - Matrícula: 20220900
 * Sistema: System Vision
 =====================================================================*/

using System;
using System.Collections.Generic;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimerParcial
{
    class Program
    {
        /*====================================================================
         * PUNTO DE ENTRADA: Main
         * - Muestra el menú principal y controla el flujo del programa.
         =====================================================================*/
        static void Main(string[] args)
        {
            // Configuración inicial de la consola
            Console.Title = "System Vision - Proyecto Final de Fundamentos";

            // Mostrar pantalla de bienvenida
            MostrarBienvenida();
            Thread.Sleep(3000);
            Console.Clear();

            // Mostrar menú principal
            MenuPrincipal();
        }

        /*====================================================================
         * EJERCICIO 1: Sintaxis básica y variables
         * - Muestra mensaje de bienvenida con nombre del grupo.
         * - Declara e imprime variables de diferentes tipos.
         =====================================================================*/
        static void MostrarBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
       __________________________________________________________
      /                                                          \
     |    _   _   _   _   _   _   _   _   _   _   _   _   _   _   |
     |   / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \  |
     |  ( S | Y | S | T | E | M |   | V | I | S | I | O | N | | ) |
     |   \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/  |
      \__________________________________________________________/
         ");
            Console.ForegroundColor = ConsoleColor.White;

            // Información de la aplicación
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine($"       Bienvenido a System Vision, by Jdvictorino Dev.");
            Console.WriteLine($"       Grupo: Fundamentos de Programación - POO");
            Console.WriteLine($"       Usuario: {Environment.UserName}");
            Console.WriteLine($"       Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"       Creado por Juan Victorino - Matrícula: 20220900");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;

            /*================================================================
             * DECLARACIÓN DE VARIABLES DE DIFERENTES TIPOS:
             * - int: números enteros
             * - string: cadenas de texto
             * - double: números decimales
             * - bool: valores verdadero/falso
             * - char: caracteres individuales
             ================================================================*/

            // Declaración de variables de distintos tipos
            int numeroEntero = 2026;
            string textoSaludo = "Hola, bienvenido al mundo de C#";
            double numeroDecimal = 3.14159;
            bool esVerdadero = true;
            char caracter = 'A';

            Console.WriteLine("     ===========================================================");
            Console.WriteLine("       EJERCICIO 1: Declaración de Variables");
            Console.WriteLine("     ===========================================================");
            Console.WriteLine($"       int numeroEntero = {numeroEntero}");
            Console.WriteLine($"       string textoSaludo = \"{textoSaludo}\"");
            Console.WriteLine($"       double numeroDecimal = {numeroDecimal}");
            Console.WriteLine($"       bool esVerdadero = {esVerdadero}");
            Console.WriteLine($"       char caracter = '{caracter}'");
            Console.WriteLine("     ===========================================================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n      [Cargando.... Espere...]");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*====================================================================
         * MENÚ PRINCIPAL:
         * - Permite navegar entre los diferentes ejercicios.
         * - Cada opción demuestra un concepto de POO.
         =====================================================================*/
        static void MenuPrincipal()
        {
            int opcion = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
      __________________________________________________________
     /                                                          \
    |    _   _   _   _   _   _   _   _   _   _   _   _   _   _   |
    |   / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \  |
    |  ( S | Y | S | T | E | M |   | V | I | S | I | O | N ) | | |
    |   \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/  |
     \__________________________________________________________/
        ");
            Console.ForegroundColor = ConsoleColor.White;
            // Mostrar opciones del menú
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("                         MENÚ PRINCIPAL                         ");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Opción 1: Presentarse");
            Console.WriteLine("      Opción 2: Par o Impar");
            Console.WriteLine("      Opción 3: Sonidos de Animales");
            Console.WriteLine("      Opción 4: Cuenta Bancaria");
            Console.WriteLine("      Opción 5: Vehículos");
            Console.WriteLine("      Opción 6: Salir");
            Console.WriteLine("     ===========================================================");

            // Validar entrada del usuario
            while (opcion < 1 || opcion > 6)
            {
                Console.Write("\n      Ingrese su opción (1-6): ");
                string input = Console.ReadLine() ?? "";
                if (!int.TryParse(input, out opcion) || opcion < 1 || opcion > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("      ❌ Opción no válida. Intente de nuevo.");
                    Console.ForegroundColor = ConsoleColor.White;
                    opcion = 0;
                }
            }

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    EjercicioClasesObjetos();
                    break;
                case 2:
                    Console.Clear();
                    EjercicioEstructurasControl();
                    break;
                case 3:
                    Console.Clear();
                    EjercicioHerenciaPolimorfismo();
                    break;
                case 4:
                    Console.Clear();
                    EjercicioEncapsulamiento();
                    break;
                case 5:
                    Console.Clear();
                    EjercicioInterfaces();
                    break;
                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n      ¡Hasta luego! Gracias por usar System Vision.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                    break;
            }

            // Volver al menú
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n      Presiona Enter para volver al menú principal...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
            MenuPrincipal();
        }

        /*====================================================================
         * EJERCICIO 3: Clases y Objetos
         * - Crea objetos de la clase Persona (uno por integrante).
         * - Llama al método Presentarse() de cada objeto.
         =====================================================================*/
        static void EjercicioClasesObjetos()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("          EJERCICIO 3: CLASES Y OBJETOS         ");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Trbaje Solo - Pero, creo 3 objetos de tipo Persona...\n");

            // Crear tres objetos Persona (uno por integrante del grupo)
            Persona persona1 = new Persona("Juan Victorino", 33);
            Persona persona2 = new Persona("Jesus de Nazareth", 2000);
            Persona persona3 = new Persona("Yo Mismito", 33);

            Console.WriteLine("     -----------------------------------------------------------");
            Console.WriteLine("      MI GRUPO SOY YO MISMO Y YA:");
            Console.WriteLine("     -----------------------------------------------------------\n");

            // Llamar al método Presentarse de cada objeto
            persona1.Presentarse();
            Console.WriteLine();
            persona2.Presentarse();
            Console.WriteLine();
            persona3.Presentarse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*====================================================================
         * EJERCICIO 2: Estructuras de Control
         * - Pide un número y determina si es par o impar.
         * - Usa un bucle for para imprimir números del 1 al 10.
         =====================================================================*/
        static void EjercicioEstructurasControl()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("          EJERCICIO 2: ESTRUCTURAS DE CONTROL                   ");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;

            // Parte 1: Verificar si un número es par o impar
            Console.WriteLine("\n      Verificar número PAR o IMPAR");
            Console.WriteLine("     -----------------------------------------------------------");
            Console.Write("      Ingresa un número entero: ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int numeroUsuario))
            {
                // Uso de estructura IF-ELSE para determinar par o impar
                if (numeroUsuario % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"      El número {numeroUsuario} es PAR.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"      El número {numeroUsuario} es IMPAR.");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("      El valor ingresado no es un número válido.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // Parte 2: Bucle FOR para imprimir del 1 al 10
            Console.WriteLine("\n      Contar los numeros del 1 al 10");
            Console.WriteLine("     -----------------------------------------------------------");
            Console.Write("      ");

            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                // Imprimir el número actual con formato
                Console.Write($"[{i}] ");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*====================================================================
         * EJERCICIO 4 y 5: Herencia y Polimorfismo
         * - Crea objetos Perro y Gato (heredan de Animal).
         * - Usa List<Animal> para demostrar polimorfismo.
         =====================================================================*/
        static void EjercicioHerenciaPolimorfismo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("          EJERCICIO 4 : HERENCIIA             ");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n      Creando objetos de clases derivadas");
            Console.WriteLine("     -----------------------------------------------------------");

            // Crear objetos de las clases derivadas
            Perro miPerro = new Perro("Max");
            Gato miGato = new Gato("Whiskers");

            Console.WriteLine("      Creando un Perro llamado 'Max'...");
            Console.WriteLine("      Creando un Gato llamado 'Whiskers'...\n");

            Console.WriteLine("      Llamando a HacerSonido() de cada animal:");
            Console.WriteLine("     -----------------------------------------------------------");
            miPerro.HacerSonido();
            miGato.HacerSonido();

            // EJERCICIO 5: Polimorfismo con List<Animal>
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("          EJERCICIO 5 : POLIMORFISMO             ");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Creando una lista List<Animal> con diferentes animales...\n");

            // Crear lista de animales (Polimorfismo)
            List<Animal> animales = new List<Animal>
            {
                new Perro("Rocky"),
                new Gato("Mittens"),
                new Perro("Buddy"),
                new Gato("Luna")
            };

            Console.WriteLine("          Estos son los sonidos de los animales:");
            Console.WriteLine("     -----------------------------------------------------------\n");

            // Recorrer la lista y llamar al método polimórfico
            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*====================================================================
         * EJERCICIO 6: Encapsulamiento
         * - Demuestra el uso de atributos privados.
         * - Usa métodos públicos para acceder al saldo.
         =====================================================================*/
        static void EjercicioEncapsulamiento()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("          EJERCICIO 6: ENCAPSULAMIENTO");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n      Mi Cuenta Bancaria...\n");

            // Crear objeto CuentaBancaria
            CuentaBancaria miCuenta = new CuentaBancaria("Juan Victorino", "1234-5678-9012");

            // Mostrar saldo inicial
            Console.WriteLine("      Estado inicial de la cuenta:");
            miCuenta.ObtenerSaldo();

            // Realizar depósitos
            Console.WriteLine("\n      Realizando operaciones:");
            Console.WriteLine("     -----------------------------------------------------------");

            miCuenta.Depositar(1000.00m);
            miCuenta.Depositar(500.50m);
            miCuenta.Depositar(250.25m);

            // Intentar depósito inválido
            Console.WriteLine("\n      Intentando depósito de monto negativo:");
            miCuenta.Depositar(-100m);

            // Mostrar saldo final
            Console.WriteLine("\n      Estado final de la cuenta:");
            miCuenta.ObtenerSaldo();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*====================================================================
         * EJERCICIO 7: Interfaces y Abstracción
         * - Demuestra la implementación de interfaces.
         * - Usa IVehiculo con Carro y Motocicleta.
         =====================================================================*/
        static void EjercicioInterfaces()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("          EJERCICIO 7: INTERFACES Y ABSTRACCIÓN                 ");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n      Creando vehículos que implementan IVehiculo...\n");

            // Crear objetos que implementan la interfaz IVehiculo
            Carro miCarro = new Carro("Toyota", "Corolla 2024");
            Motocicleta miMoto = new Motocicleta("Yamaha", 600);

            Console.WriteLine("     -----------------------------------------------------------");
            Console.WriteLine("      PROBANDO EL CARRO:");
            Console.WriteLine("     -----------------------------------------------------------\n");

            miCarro.Encender();
            Console.WriteLine();
            miCarro.Apagar();

            Console.WriteLine("\n     -----------------------------------------------------------");
            Console.WriteLine("      PROBANDO LA MOTOCICLETA:");
            Console.WriteLine("     -----------------------------------------------------------\n");

            miMoto.Encender();
            Console.WriteLine();
            miMoto.Apagar();

            // Demostración adicional: usando la interfaz
            Console.WriteLine("\n     -----------------------------------------------------------");
            Console.WriteLine("      INTERFAZ IVehiculo");
            Console.WriteLine("     -----------------------------------------------------------\n");

            List<IVehiculo> vehiculos = new List<IVehiculo> { miCarro, miMoto };

            foreach (IVehiculo vehiculo in vehiculos)
            {
                vehiculo.Encender();
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     ===========================================================");
            Console.WriteLine("      DEME PUNTOS EXTRAS.");
            Console.WriteLine("      POR FAVOR");
            Console.WriteLine("      :)");
            Console.WriteLine("     ===========================================================");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
