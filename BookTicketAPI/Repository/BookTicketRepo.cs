using BookTicketAPI.DBContext;
using BookTicketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicketAPI.Repository
{
    public class BookTicketRepo:IBookTicket
    {
        private readonly BookTicketDBContext _context;
        public BookTicketRepo(BookTicketDBContext context)
        {
            _context = context;
        }

        public bool BookNewTicket(BookedTicketData model)
        {
            try
            {
                _context.BookTicketData.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CancelBookedTicket(int PNRId)
        {
            try
            {
                var data = _context.BookTicketData.Where(x => x.PNRId == PNRId).FirstOrDefault();
                _context.BookTicketData.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BookedTicketData> GetBookingByPNR(int PNRId)
        {
            try
            {
                return _context.BookTicketData.Where(x => x.PNRId == PNRId).ToList();
            }
            catch (Exception)
            {
                return new List<BookedTicketData>();
            }
        }
    }
}
