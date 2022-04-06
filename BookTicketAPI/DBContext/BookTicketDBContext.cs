using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTicketAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTicketAPI.DBContext
{
    public class BookTicketDBContext:DbContext
    {
        public BookTicketDBContext(DbContextOptions<BookTicketDBContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<BookedTicketData> BookTicketData { get; set; }
    }
}
