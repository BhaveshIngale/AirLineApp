using InventoryAPI.DBContext;
using InventoryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Repository
{
    public class InventoryRepository : IInventory
    {
        private readonly InventoryDBContext _context;
        public InventoryRepository(InventoryDBContext context)
        {
            _context = context;
        }

        public bool AddNewInventory(Inventory model)
        {
            try
            {
                _context.M_Inventory.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Inventory> SearchFlight(string source, string destination,bool roundTrip)
        {
            try
            {
                return _context.M_Inventory.Where(x => x.Source == source && x.Destination == destination && x.RoundTrip == roundTrip).ToList();
            }
            catch (Exception)
            {
                return new List<Inventory>();
            }
        }
    }
}
