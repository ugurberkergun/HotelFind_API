using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MSI\\MSSQLSERVER01;Database=HotelDb;uid=z29;pwd=11072010;");
        }

        public DbSet<Hotel> Hotels { get; set; } // business katmanında hoteldbcontxt new lediğimizde hotels diye bir property gelecek
    }
}
