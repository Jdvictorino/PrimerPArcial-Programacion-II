using System;

namespace PrimerParcial
{
    /*====================================================================
     * CLASE BASE: Animal
     * - Define la estructura base para todos los animales.
     * - Contiene el método virtual HacerSonido() que puede ser
     *   sobrescrito por las clases hijas.
     * 
     * Ejercicio 4: Herencia
     =====================================================================*/
    public class Animal
    {
        // Propiedad para el nombre del animal
        public string Nombre { get; set; }

        // Constructor de la clase base
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        /*====================================================================
         * MÉTODO VIRTUAL: HacerSonido()
         * - Método que puede ser sobrescrito en clases derivadas.
         * - Permite implementar POLIMORFISMO.
         =====================================================================*/
        public virtual void HacerSonido()
        {
            Console.WriteLine("      El animal hace un sonido...");
        }
    }

    /*====================================================================
     * CLASE: Perro (hereda de Animal)
     * - Sobrescribe el método HacerSonido() para decir "Guau, guau".
     =====================================================================*/
    public class Perro : Animal
    {
        // Constructor que llama al constructor de la clase base
        public Perro(string nombre) : base(nombre)
        {
        }

        // Sobrescribe el método HacerSonido de la clase padre
        public override void HacerSonido()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"      🐕 {Nombre} dice: ¡Guau, guau!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    /*====================================================================
     * CLASE DERIVADA: Gato (hereda de Animal)
     * - Sobrescribe el método HacerSonido() para decir "Miau".
     =====================================================================*/
    public class Gato : Animal
    {
        // Constructor que llama al constructor de la clase base
        public Gato(string nombre) : base(nombre)
        {
        }

        // Sobrescribe el método HacerSonido de la clase padre
        public override void HacerSonido()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"      🐱 {Nombre} dice: ¡Miau!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
