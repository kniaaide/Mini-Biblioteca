using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca
{
    internal class Persona
    {
        // aqui va el codigo de la clase Persona
        //crearemos una clase persona con las propiedades nombre, edad y genero
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }
    }
}
