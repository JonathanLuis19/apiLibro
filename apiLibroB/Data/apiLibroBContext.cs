using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiLibroB.Model;

namespace apiLibroB.Data
{
    public class apiLibroBContext : DbContext
    {
        public apiLibroBContext (DbContextOptions<apiLibroBContext> options)
            : base(options)
        {
        }

        public DbSet<apiLibroB.Model.Libro> Libro { get; set; }
    }
}
