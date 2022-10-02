using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoryLogic : BaseLogic, ILogic<Categories>
    {

        public List<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

    }
}
