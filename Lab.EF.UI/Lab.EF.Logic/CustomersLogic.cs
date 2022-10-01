using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Data;
using Lab.EF.Entities;

namespace Lab.EF.Logic
{
    public class CustomersLogic : BaseLogic , ILogic<Customers>
    {

        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

    }
}
