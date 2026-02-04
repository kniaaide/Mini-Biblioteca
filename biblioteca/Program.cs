
using System;
using System.Globalization;
using System.Threading;

namespace biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //en español (España)
           //pediremos nombre ,edad y genero a la persona
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su género:");
            string genero = Console.ReadLine();
            Persona persona = new Persona(nombre, edad, genero);
            //pediremos titulo, autor y año de publicacion del libro
            Console.WriteLine("Ingrese el título del libro:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro:");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese el año de publicación del libro:");
            int anioPublicacion = int.Parse(Console.ReadLine());
            LIbro libro = new LIbro(titulo, autor, anioPublicacion);
            //mostraremos la informacion de la persona y del libro
            Console.WriteLine($"\nInformación de la persona:\nNombre: {persona.Nombre}\nEdad: {persona.Edad}\nGénero: {persona.Genero}");
            Console.WriteLine($"\nInformación del libro:\nTítulo: {libro.Titulo}\nAutor: {libro.Autor}\nAño de Publicación: {libro.AnioPublicacion}");

        }
    }
}