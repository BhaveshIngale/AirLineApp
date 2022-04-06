using InventoryAPI.Models;
using InventoryAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventory _repo;
        public InventoryController(IInventory repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("addInventory")]
        public ActionResult AddInventory(Inventory model)
        {
            bool IsAdded = _repo.AddNewInventory(model);
            return Ok(IsAdded);
        }
        [HttpGet]
        [Route("searchFlight")]
        public ActionResult SearchFlight(string Source,string Destination,bool RoundTrip)
        {
           List<Inventory>list = _repo.SearchFlight(Source, Destination,RoundTrip);
            return Ok(list);
        }
    }
}
