using System;
using System.Collections.Generic;

namespace ProyectoFinalFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // 1. SINTAXIS BÁSICA Y VARIABLES
            // ==========================================
            Console.WriteLine("=== EJERCICIO 1: Bienvenida y Variables ===");

            // Mensaje de bienvenida
            string nombreGrupo = "Los Innovadores del Código";
            Console.WriteLine($"¡Bienvenidos al proyecto del grupo: {nombreGrupo}!");

            // Declaración de variables de distintos tipos
            int anioCurso = 2026;
            string materia = "Programación I";
            double calificacionEsperada = 100.00;
            bool esDivertido = true;

            Console.WriteLine($"Materia: {materia}");
            Console.WriteLine($"Año: {anioCurso}");
            Console.WriteLine($"Meta de nota: {calificacionEsperada}");
            Console.WriteLine($"¿Es divertido programar?: {esDivertido}\n");

            // ==========================================
            // 2. ESTRUCTURAS DE CONTROL
            // ==========================================
            Console.WriteLine("=== EJERCICIO 2: Estructuras de Control ===");

            // Par o Impar
            Console.Write("Ingresa un número entero para verificar si es par o impar: ");
            string input = Console.ReadLine();

            // Validación simple para evitar errores si no escriben un número
            if (int.TryParse(input, out int numeroUsuario))
            {
                if (numeroUsuario % 2 == 0)
                    Console.WriteLine($"El número {numeroUsuario} es PAR.");
                else
                    Console.WriteLine($"El número {numeroUsuario} es IMPAR.");
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido.");
            }

            // Bucle For (1 al 10)
            Console.WriteLine("\nContando del 1 al 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // 3. CLASES Y OBJETOS
            // ==========================================
            Console.WriteLine("=== EJERCICIO 3: Clases y Objetos (Persona) ===");

            // Creación de objetos (Instanciación)
            Persona integrante1 = new Persona("Juan", 28);
            Persona integrante2 = new Persona("Maria", 24);
            Persona integrante3 = new Persona("Pedro", 30);

            // Llamada al método Presentarse
            integrante1.Presentarse();
            integrante2.Presentarse();
            integrante3.Presentarse();
            Console.WriteLine();

            // ==========================================
            // 4 & 5. HERENCIA Y POLIMORFISMO
            // ==========================================
            Console.WriteLine("=== EJERCICIO 4 y 5: Herencia y Polimorfismo (Animales) ===");

            // Polimorfismo: Usamos una lista de la clase base 'Animal' para guardar hijos distintos
            List<Animal> zoologico = new List<Animal>();

            // Agregamos un Perro y un Gato a la lista
            zoologico.Add(new Perro("Firulais"));
            zoologico.Add(new Gato("Michi"));

            // Recorremos la lista y el comportamiento cambia según el objeto (Polimorfismo)
            foreach (Animal animal in zoologico)
            {
                Console.Write($"{animal.Nombre} dice: ");
                animal.HacerSonido();
            }
            Console.WriteLine();

            // ==========================================
            // 6. ENCAPSULAMIENTO
            // ==========================================
            Console.WriteLine("=== EJERCICIO 6: Encapsulamiento (Cuenta Bancaria) ===");

            CuentaBancaria miCuenta = new CuentaBancaria();

            // Intentamos depositar dinero
            miCuenta.Depositar(5000.50m);
            miCuenta.Depositar(1500.00m);

            // Mostramos el saldo usando el método público
            Console.WriteLine($"Saldo consultado: RD${miCuenta.ObtenerSaldo()}");
            Console.WriteLine();

            // ==========================================
            // 7. INTERFACES Y ABSTRACCIÓN
            // ==========================================
            Console.WriteLine("=== EJERCICIO 7: Interfaces (Vehículos) ===");

            IVehiculo miCarro = new Carro("Toyota Corolla");
            IVehiculo miMoto = new Motocicleta("Yamaha R1");

            // Probando el Carro
            miCarro.Encender();
            miCarro.Apagar();

            Console.WriteLine("---");

            // Probando la Moto
            miMoto.Encender();
            miMoto.Apagar();

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Fin del programa. Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }

    // ######################################################
    // DEFINICIÓN DE CLASES E INTERFACES
    // ######################################################

    // --- EJERCICIO 3: CLASE PERSONA ---
    class Persona
    {
        // Propiedades auto-implementadas
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor para inicializar los datos fácilmente
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    // --- EJERCICIO 4 & 5: HERENCIA Y POLIMORFISMO ---

    // Clase Base
    class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // 'virtual' permite que las clases hijas sobrescriban este método
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un ruido genérico.");
        }
    }

    // Clase Hija 1
    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        // 'override' modifica el comportamiento del método base
        public override void HacerSonido()
        {
            Console.WriteLine("¡Guau, guau!");
        }
    }

    // Clase Hija 2
    class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine("¡Miau, miau!");
        }
    }

    // --- EJERCICIO 6: ENCAPSULAMIENTO ---
    class CuentaBancaria
    {
        // Atributo privado: Nadie fuera de la clase puede modificarlo directamente
        private decimal _saldo;

        public CuentaBancaria()
        {
            _saldo = 0; // Saldo inicial
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                _saldo += monto;
                Console.WriteLine($"Se han depositado RD${monto} exitosamente.");
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser positivo.");
            }
        }

        public decimal ObtenerSaldo()
        {
            // Solo lectura del saldo
            return _saldo;
        }
    }

    // --- EJERCICIO 7: INTERFACES ---

    // La interfaz define el "QUÉ" deben hacer las clases, pero no el "CÓMO"
    interface IVehiculo
    {
        void Encender();
        void Apagar();
    }

    class Carro : IVehiculo
    {
        public string Modelo { get; set; }

        public Carro(string modelo)
        {
            Modelo = modelo;
        }

        public void Encender()
        {
            Console.WriteLine($"El carro {Modelo} gira la llave y el motor ruge.");
        }

        public void Apagar()
        {
            Console.WriteLine($"El carro {Modelo} se ha detenido y apagado el motor.");
        }
    }

    class Motocicleta : IVehiculo
    {
        public string Modelo { get; set; }

        public Motocicleta(string modelo)
        {
            Modelo = modelo;
        }

        public void Encender()
        {
            Console.WriteLine($"La motocicleta {Modelo} arranca con una patada al pedal.");
        }

        public void Apagar()
        {
            Console.WriteLine($"La motocicleta {Modelo} baja la pata de apoyo y se apaga.");
        }
    }
}