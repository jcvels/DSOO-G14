using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Colecciones
{
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
