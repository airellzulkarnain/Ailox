using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ailox_wms.Models;

namespace ailox_wms.Data
{
    public class AiloxContext:DbContext
    {
        public AiloxContext(DbContextOptions<AiloxContext> options): base(options) 
        { }

        public DbSet<User> Users { get; set; }
    }

}
