using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class FitnessCenterContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FitnessCenter;Trusted_connection=true");


        }
        public DbSet<BlogPost> BlogPost  { get; set; }
        public DbSet<Campain> Campain { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<ContactInfo> Contactİnfo { get; set; }
        public DbSet<Customer> Customer{ get; set; }
        public DbSet<MyProgrammes> MyProgrammes { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Programme> Programme { get; set; }
        public DbSet<Supplement> Supplement { get; set; }
        public DbSet<Trainer> Trainer { get; set; }

    }

}
