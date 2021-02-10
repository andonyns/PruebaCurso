using System;

namespace Ejemplo
{
    abstract class Animal
    {
        protected string _nombre;
        private bool estaVivo;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public void Nacer()
        {
            Console.WriteLine("Hola Mundo!");
            estaVivo = true;
        }

        public void Morir()
        {
            Console.WriteLine("Adiós Mundo! 😪");
            estaVivo = false;
        }

        public abstract string EmitirSonido();


    }
}