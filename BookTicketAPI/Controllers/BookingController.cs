using BookTicketAPI.Models;
using BookTicketAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicketAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookTicket _repo;
        public BookingController(IBookTicket repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("bookTicket")]
        public ActionResult BookTicket(BookedTicketData model)
        {
            bool IsBooked= _repo.BookNewTicket(model);
            return Ok(IsBooked);
        }
        [HttpGet]
        [Route("getBookingByPNR")]
        public ActionResult GetBookingbyPNR(int PNRId)
        {
           List<BookedTicketData>list= _repo.GetBookingByPNR(PNRId);
           return Ok(list);
        }
        [HttpDelete]
        [Route("cancelTicket")]
        public ActionResult CancelTicket(int PNRId)
        {
            bool IsCancel = _repo.CancelBookedTicket(PNRId);
            return Ok(IsCancel);
        }

    }
}
