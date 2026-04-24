using System;
using System.Collections.Generic;

namespace Colecciones
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

    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        public Biblioteca()
        {
            libros = new List<Libro>();
            lectores = new List<Lector>();
        }

        public bool altaLector(string nombre, string dni)
        {
            if (buscarLector(dni) != null)
                return false;

            lectores.Add(new Lector(nombre, dni));
            return true;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {
            Console.WriteLine("Libros en biblioteca:");
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        public string prestarLibro(string titulo, string dni)
        {
            Lector lector = buscarLector(dni);
            if (lector == null)
                return "LECTOR INEXISTENTE";
            if (!lector.puedePedir())
                return "TOPE DE PRESTAMO ALCAZADO";
            Libro libro = buscarLibro(titulo);
            if (libro == null)
                return "LIBRO INEXISTENTE";
            if (lector.agregarPrestamo(libro, libros))
                return "PRESTAMO EXITOSO";
            return "ERROR AL PROCESAR PRESTAMO";
        }

        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
                i++;
            if (i != libros.Count)
                libroBuscado = libros[i];
            return libroBuscado;
        }

        private Lector buscarLector(string dni)
        {
            Lector encontrado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni))
                i++;
            if (i != lectores.Count)
                encontrado = lectores[i];
            return encontrado;
        }
    }

    internal class Libro
    {
        public string titulo;
        public string autor;
        public string editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public override string ToString()
        {
            return "Titulo: " + titulo + " Autor: " + autor + " Editorial: " + editorial;
        }
    }

    internal class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> prestamos;
        private const int MAX_PRESTAMOS = 3;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.prestamos = new List<Libro>();
        }

        public string getDni()
        {
            return dni;
        }

        public bool puedePedir()
        {
            return prestamos.Count < MAX_PRESTAMOS;
        }
        public bool agregarPrestamo(Libro libro, List<Libro> bibliotecaLibros)
        {
            if (!puedePedir())
                return false;

            bool removed = bibliotecaLibros.Remove(libro);
            if (!removed)
                return false;

            prestamos.Add(libro);
            return true;
        }

        public override string ToString()
        {
            return $"Lector: {nombre} (DNI: {dni}) - Prestamos vigentes: {prestamos.Count}";
        }
    }
}
