using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineAPI.Models
{
    public class AirLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int AirLineId { get; set; }
       public string AirLineName { get; set; }
       public string Contact { get; set; }
       public string Address { get; set; }
       public bool IsBlock { get; set; } = false;
    }
}
