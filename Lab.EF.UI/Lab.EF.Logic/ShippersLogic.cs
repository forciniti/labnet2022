using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
   public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }
        public void Add(Shippers newRecord)
        {
            _context.Shippers.Add(newRecord);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperXEliminar = _context.Shippers.Find(id);
            _context.Shippers.Remove(shipperXEliminar);
            _context.SaveChanges();
        }

        public void Update(Shippers record)
        {         
            var shipperUpdate = _context.Shippers.Find(record.ShipperID);
            shipperUpdate.CompanyName= record.CompanyName;
            _context.SaveChanges();
        }
    }
}
