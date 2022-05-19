using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrintDataAcessLayer.Interface
{
    public interface IRepository<T>
    {
        public  Task<T> Create(T entity);
        public T GetById(int Id);
    }
}
