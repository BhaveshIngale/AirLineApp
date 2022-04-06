using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirLineAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AirLineAPI.DBContext
{
    public class AirLineDBContext:DbContext
    {
        public AirLineDBContext(DbContextOptions<AirLineDBContext> options):base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<AirLine> M_AirLine { get; set; }
    }
}
