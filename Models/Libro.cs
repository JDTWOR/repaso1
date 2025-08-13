using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string titulo { get; set; }

        public List<Genero> Generos { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }


    }
}
