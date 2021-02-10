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
            Console.WriteLine("Ejercicio de Kevin: ")
            Console.WriteLine(AgeToDays.CalcEdad(15));
>>>>>>> 0d2dcdace9f7a9de7b4b3cdf440ac91c5ced5d59

            Console.WriteLine("Ejercicio de Kimberly: ");
            var multi = new MultiplicacionNumeros();
            Console.WriteLine(multi.Mult(5, 7));

        }
    }
}
