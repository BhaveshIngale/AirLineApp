using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserAPI.Models;

namespace UserAPI.DBContext
{
    public class UserDBContext:DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options):base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<User> users { get; set; }
    }
}
