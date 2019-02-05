using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Data
{
    public class TrueCoachJournalDbContext : DbContext
    {
        public TrueCoachJournalDbContext(DbContextOptions<TrueCoachJournalDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ModelBuilder.Entity<Profile>().HasKey(je => new { je.profileID, je.profile });

            modelBuilder.Entity<journal>().HasData(
                new Journal
                {

                }
                
                
                )
        }
    }
    {
    }
}
