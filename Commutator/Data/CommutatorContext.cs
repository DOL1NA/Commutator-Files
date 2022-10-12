using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Commutator.Models;

namespace Commutator.Data
{
    public class CommutatorContext : DbContext
    {
        public CommutatorContext (DbContextOptions<CommutatorContext> options)
            : base(options)
        {
        }

        public DbSet<Commutator.Models.Movie> Movie { get; set; }
    }
}
