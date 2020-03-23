using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ClassLibraryNetCore
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VQ90SA7\\SQLEXPRESS;Database = EFCore2020; Trusted_Connection = True");
 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Kind of Seed Method
            modelBuilder.Entity<Person>().HasData(
                Person.Create(1, "Theodor", "Gabriel", "Grigorovschi", "072134211"));
        }


    }
}
