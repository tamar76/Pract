using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Services
{
    public interface IService<T>
    {
       
        Task<List<T>> Add(List<T> entity);
       
    }
}
