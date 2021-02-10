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
		    Prueba.Respuesta("hola");


            Console.WriteLine("Ejercicio de Gonzalo: ");
            var area = new areaTriandulo();
            Console.WriteLine(area.triArea(12, 32));

<<<<<<< HEAD
            Console.WriteLine("Ejercicio de Jeremy: ");
            var contarNum = new Conteo();
            contarNum.Contar();
=======

            Console.WriteLine("Ejercicio de Kimberly: ");
            var multi = new MultiplicacionNumeros();
            Console.WriteLine(multi.Mult(5, 7));
>>>>>>> 64f4c18f77255ee1a8846816fc5251ef2c65db96

        }
    }
}
