using AirLineAPI.DBContext;
using AirLineAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineAPI.Repository
{
    public class AirLineRepository : IAirLine
    {
        private readonly AirLineDBContext _context;
        public AirLineRepository(AirLineDBContext context)
        {
            _context = context;
        }
        public bool AddNewAirLine(AirLine model)
        {
            try
            {
                _context.M_AirLine.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<AirLine> GetAllAirlines()
        {
            try
            {
                return _context.M_AirLine.ToList();
            }
            catch (Exception)
            {
                return new List<AirLine>();
            }
        }

        public bool UpdateAirLine(int airLineId, bool status)
        {
            try
            {
                var AirLineData=_context.M_AirLine.Where(x => x.AirLineId == airLineId).FirstOrDefault();
                AirLineData.IsBlock = status;
                _context.Entry(AirLineData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
