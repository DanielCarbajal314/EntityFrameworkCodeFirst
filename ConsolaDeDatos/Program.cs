using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase3.Contextos;
using Clase3.Modelos;

namespace ConsolaDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblitoteca = new Biblioteca();
            Libro nuevoLibro = new Libro();
            nuevoLibro.Autor = "Daniel";
            nuevoLibro.Edicion = 3;
            nuevoLibro.Genero = "Terror";
            nuevoLibro.Nombre = "Cibertac";
            biblitoteca.Libros.Add(nuevoLibro);
            biblitoteca.SaveChanges();
        }
    }
}
