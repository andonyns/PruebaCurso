
using System;

namespace Ejemplo
{
    class Perro : Animal
    {
        private int edad;
        private string raza;
        public Perro(string nuevoNombre, int nuevaEdad, string nuevaRaza)
        {
            nombre = nuevoNombre;
            edad = nuevaEdad;
            raza = nuevaRaza;
        }

        public Perro()
        {

        }

        public override string EmitirSonido()
        {
            return "guau. Mi nombre es: " + _nombre;
        }

        public string TenerHijos()
        {
            return "viviparo";
        }

        public void AlgoQueSoloElPerroHace()
        {
            //no hace nada
        }

    }
}
