using System;
using System.Collections.Generic;

namespace TP1_Colecciones
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.altaLector("Matias Castillo", "12345678");
            biblioteca.altaLector("Pedro Gomez", "87654321");

            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();

            Console.WriteLine(biblioteca.prestarLibro("Libro1", "12345678")); // PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.prestarLibro("Libro1", "12345678")); // LIBRO INEXISTENTE
            Console.WriteLine(biblioteca.prestarLibro("Libro2", "00000000")); // LECTOR INEXISTENTE

            // Prestamos para alcanzar tope
            Console.WriteLine(biblioteca.prestarLibro("Libro2", "12345678"));
            Console.WriteLine(biblioteca.prestarLibro("Libro3", "12345678"));
            Console.WriteLine(biblioteca.prestarLibro("Libro4", "12345678")); // TOPE DE PRESTAMO ALCAZADO

            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();

            void cargarLibros(int cantidad)
            {
                bool pude;
                for (int i = 1; i <= cantidad; i++) 
                {
                    pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                        Console.WriteLine("Libro" + i + " agregado correctamente");
                    else
                        Console.WriteLine("Libro" + i + " ya existe en la biblioteca");
                }
            }
        }
    }
}
