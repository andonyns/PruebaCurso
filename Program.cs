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


            Console.WriteLine("Ejercicio de Gonzalo: ");
            var area = new areaTriandulo();
            Console.WriteLine(area.triArea(12, 32));

        }
    }
}
