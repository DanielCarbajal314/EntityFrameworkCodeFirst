using Clase3.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Contextos
{
    public class Biblioteca:DbContext
    {
        public Biblioteca() : base("BibliotecaDB") { }
        public DbSet<Libro> Libros { get; set; }
    }
}
