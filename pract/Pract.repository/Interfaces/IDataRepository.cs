using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Repository.Interfaces
{
    public interface IDataRepository<T>
    {
        Task<List<T>> AddAsync(List<T> entity);
    }
}
