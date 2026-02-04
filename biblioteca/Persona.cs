using System;

namespace biblioteca
{
    /// <summary>Representa una persona con nombre, edad y género.</summary>
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public override string ToString() => $"{Nombre}, {Edad} años, {Genero}";
    }
}