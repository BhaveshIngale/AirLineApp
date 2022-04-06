using BookTicketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicketAPI.Repository
{
    public interface IBookTicket
    {
        bool BookNewTicket(BookedTicketData model);
        List<BookedTicketData> GetBookingByPNR(int pNRId);
        bool CancelBookedTicket(int pNRId);
    }
}
