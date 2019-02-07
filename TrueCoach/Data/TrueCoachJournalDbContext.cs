using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueCoach.Models;

namespace TrueCoach.Data
{
    public class TrueCoachJournalDbContext : DbContext
    {
        public TrueCoachJournalDbContext(DbContextOptions<TrueCoachJournalDbContext> options): base(options)
        {

        }
                 
        public DbSet<Journal> Journal { get; set; }
        public DbSet<Regeneration> Regeneration { get; set; }
    }
    
    
}
