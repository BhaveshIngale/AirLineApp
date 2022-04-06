using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Models
{
    public class Inventory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryId { get; set; }
        public int FlightId { get; set; }
        public int AirLineId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string InstrumentUsed { get; set; }
        public int Cost { get; set; }
        public int TotalSeats { get; set; }
        public int BusinessClassSeats { get; set; }
        public int EconomyClassSeat { get; set; }
        public bool RoundTrip { get; set; }
        public string MealPreferences { get; set; }
    }
}
