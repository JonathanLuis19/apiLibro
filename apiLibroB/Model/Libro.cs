using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiLibroB.Model
{
    public class Libro
    {
        public int Id { get; set; }

        public String nombre { get; set; }

        public String autor { get; set; }

        public int isbn { get; set; }

        public int publicacion { get; set; }
    }

}
