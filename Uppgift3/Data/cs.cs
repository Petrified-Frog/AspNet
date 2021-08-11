using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uppgift3.Data.Entities;

namespace Uppgift3.Areas.Identity.Data.AuthDbContext
{
    public class cs : DbContext
    {
        public cs (DbContextOptions<cs> options)
            : base(options)
        {
        }

        public DbSet<Uppgift3.Data.Entities.Product> Product { get; set; }
    }
}
