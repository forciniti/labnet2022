using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();
        void Add( T newRecord);
        void Delete(int id);

        void Update(T record);
    }
}
