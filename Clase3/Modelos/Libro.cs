using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Modelos
{
    public class Libro : BaseEntity
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public int Edicion { get; set; }
        public string Genero { get; set; }
    }
}
