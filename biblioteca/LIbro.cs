using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca
{
    internal class LIbro
    {
        // aqui va el codigo de la clase Libro
        //crearemos una clase libro con las propiedades titulo, autor y anioPublicacion
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }

        public LIbro(string titulo, string autor, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }
    }
}
