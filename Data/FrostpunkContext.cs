using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using frostpunk2_ciekawostki.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace frostpunk2_ciekawostki.Data
{
    public class FrostpunkContext : DbContext
    {
        public FrostpunkContext(DbContextOptions<FrostpunkContext> options): base(options) {}
        
        public DbSet<Ciekawostka> Ciekawostki { get; set; }
    }
}