using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }

        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                new Value{Id =1,Name="Naveen"},
                new Value{Id =2,Name="Navya"},
                new Value{Id =3,Name="Naveen Reddy"},
                new Value{Id =4,Name="Name"}
            );
        }
    }
}
