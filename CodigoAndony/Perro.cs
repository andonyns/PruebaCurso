
using System;

namespace Ejemplo
{
    class Perro : Animal
    {
        private int edad;
        public Perro(string nuevoNombre, int nuevaEdad)
        {
            nombre = nuevoNombre;
            edad = nuevaEdad;
            //Constructor, favor no borrar porque es un recordatorio
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
