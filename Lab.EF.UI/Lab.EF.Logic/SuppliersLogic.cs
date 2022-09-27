using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Data;
using Lab.EF.Entities;

namespace Lab.EF.Logic
{
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {
        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public void Add(Suppliers newRecord)
        {
            _context.Suppliers.Add(newRecord);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplierXEliminar = _context.Suppliers.Find(id);
            _context.Suppliers.Remove(supplierXEliminar);
            _context.SaveChanges();
        }

    
        public void Update(Suppliers record)
        {
            var supplierUpdate = _context.Suppliers.Find(record.SupplierID);
            supplierUpdate.Phone = record.Phone;
            _context.SaveChanges();
        }
    }
}
