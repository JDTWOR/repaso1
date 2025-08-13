using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; }

    }
}
