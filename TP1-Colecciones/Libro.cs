using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_Colecciones
{
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
}
