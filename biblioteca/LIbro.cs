using System;

namespace biblioteca
{
    /// <summary>
    /// Representa un libro con título, autor y año de publicación.
    /// </summary>
    internal class LIbro
    {
        /// <summary>Obtiene o establece el título del libro.</summary>
        public string Titulo { get; set; }

        /// <summary>Obtiene o establece el autor del libro.</summary>
        public string Autor { get; set; }

        /// <summary>Obtiene o establece el año de publicación.</summary>
        public int AnioPublicacion { get; set; }

        public LIbro(string titulo, string autor, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }

        /// <summary>Devuelve una representación textual del libro.</summary>
        public override string ToString() => $"{Titulo} — {Autor} ({AnioPublicacion})";
    }
}