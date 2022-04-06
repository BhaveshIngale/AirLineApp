using InventoryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Repository
{
    public interface IInventory
    {
        bool AddNewInventory(Inventory model);
        List<Inventory> SearchFlight(string source, string destination, bool roundTrip);
    }
}
