using System;

namespace PruebaCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio del curso!");


            Console.WriteLine("Ejercicio de Andony: ");
            var suma = new SumaNumeros();
            Console.WriteLine(suma.Sum(1, 2));

            Console.WriteLine("Ejercicio de Jeremy: ");
            var contarNum = new Conteo();
            contarNum.Contar();

        }
    }
}
