using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DE_WebCambios.Models;

namespace DE_WebCambios.Data
{
    public class DE_WebCambiosContext : DbContext
    {
        public DE_WebCambiosContext (DbContextOptions<DE_WebCambiosContext> options)
            : base(options)
        {
        }

        public DbSet<DE_WebCambios.Models.Menu> Menu { get; set; } = default!;
    }
}
