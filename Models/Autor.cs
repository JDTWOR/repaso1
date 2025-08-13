using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }

        public List<Libro> Libros { get; set; }
    }
}
