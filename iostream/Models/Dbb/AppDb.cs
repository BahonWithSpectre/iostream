using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iostream.Models.Dbb
{
    public class AppDb : DbContext
    {
        public DbSet<Request> Requests { get; set; }

        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {
            
        }

    }
}
