using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.DBContext
{
    public class InventoryDBContext:DbContext
    {
        public InventoryDBContext(DbContextOptions<InventoryDBContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Inventory> M_Inventory { get; set; }
    }
}
