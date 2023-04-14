using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP367Quiz4.Models;

namespace COMP367Quiz4.Data
{
    public class COMP367Quiz4Context : DbContext
    {
        public COMP367Quiz4Context (DbContextOptions<COMP367Quiz4Context> options)
            : base(options)
        {
        }

        public DbSet<COMP367Quiz4.Models.Book> Book { get; set; } = default!;
    }
}
