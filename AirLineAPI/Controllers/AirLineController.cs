using AirLineAPI.Models;
using AirLineAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirLineController : ControllerBase
    {
        private readonly IAirLine _repo;
        public AirLineController(IAirLine repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("addNewAirLine")]
        public ActionResult AddAirLine(AirLine model)
        {
            bool IsAdded=_repo.AddNewAirLine(model);
            return Ok(IsAdded);
        }

        [HttpGet]
        [Route("getAllAirLines")]
        public ActionResult GetAllAirLines()
        {
            List<AirLine> list=_repo.GetAllAirlines();
            return Ok(list);
        }

        [HttpPut]
        [Route("blockUnblockAirLine")]
        public ActionResult BlockUnblockAirLine(int AirLineId,bool Status)
        {
            var Result=_repo.UpdateAirLine(AirLineId, Status);
            return Ok(Result);
        }
    }
}
