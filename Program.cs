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

            Console.WriteLine("Ejercicio de Kevin: ");
            Console.WriteLine(AgeToDays.CalcEdad(15));

            Console.WriteLine("Ejercicio de Kimberly: ");
            var multi = new MultiplicacionNumeros();
            Console.WriteLine(multi.Mult(5, 7));
            Console.WriteLine("Ejercicio de Reymond");
             var resultado = new Convertir();
             Console.WriteLine(resultado.convert(4));

        }
    }
}
