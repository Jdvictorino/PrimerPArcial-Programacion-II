using System;

namespace PrimerParcial
{
    
    public class Persona
    {
        /*====================================================================
         * PROPIEDADES:
         * - Nombre: Almacena el nombre de la persona (string)
         * - Edad: Almacena la edad de la persona (int)
         =====================================================================*/

        // Propiedad para almacenar el nombre de la persona
        public string Nombre { get; set; }

        // Propiedad para almacenar la edad de la persona
        public int Edad { get; set; }

        /*====================================================================
         * - Inicializa una nueva instancia de Persona con nombre y edad.
         =====================================================================*/
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        /*====================================================================
         * MÉTODO: Presentarse()
         * - Imprime un mensaje de presentación con el nombre y edad.
         * - Ejemplo de salida: "Hola, mi nombre es Ana y tengo 25 años."
         =====================================================================*/
        public void Presentarse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"      Hola, mi nombre es {Nombre} y tengo {Edad} años.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
