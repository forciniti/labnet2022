using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
   public class ProductsLogic : BaseLogic, ILogic<Products>
    {
        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

    }
}
