using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca
{
    internal class Biblioteca
    {
        
    
        /// <summary>Representa el préstamo de un libro a una persona.</summary>
        internal class Prestamo
        {
            public Persona Persona { get; }
            public LIbro Libro { get; }
            public DateTime FechaPrestamo { get; }
            public DateTime? FechaDevolucion { get; set; }

            public Prestamo(Persona persona, LIbro libro, DateTime fechaPrestamo)
            {
                Persona = persona ?? throw new ArgumentNullException(nameof(persona));
                Libro = libro ?? throw new ArgumentNullException(nameof(libro));
                FechaPrestamo = fechaPrestamo;
            }

            public bool EstaActivo() => FechaDevolucion == null;

            public override string ToString()
                => $"{Libro.Titulo} prestado a {Persona.Nombre} el {FechaPrestamo:d}" +
                   (FechaDevolucion is DateTime d ? $", devuelto el {d:d}" : ", sin devolver");
        }
    }
}

