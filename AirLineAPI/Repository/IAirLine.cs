using AirLineAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineAPI.Repository
{
    public interface IAirLine
    {
        bool AddNewAirLine(AirLine model);
        List<AirLine> GetAllAirlines();
        bool UpdateAirLine(int airLineId, bool status);
    }
}
