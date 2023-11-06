using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tema2;

namespace Tema2.Data
{
    public class Tema2Context : DbContext
    {
        public Tema2Context (DbContextOptions<Tema2Context> options)
            : base(options)
        {
        }

        public DbSet<Tema2.Student> Student { get; set; } = default!;
    }
}
