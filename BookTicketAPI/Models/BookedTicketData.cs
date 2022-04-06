using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicketAPI.Models
{
    public class BookedTicketData
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PNRId { get; set; }
        public string PassangerName { get; set; }
        public string PassangerEmail { get; set; }
        public int NumberOfSeatsToBook { get; set; }
        public string MealOptions { get; set; }
        public string SeatNumbers { get; set; }
        public int InventoryId { get; set; }

    }
}
