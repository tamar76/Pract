using Microsoft.EntityFrameworkCore;
using Pract.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Repository.Repositories
{
    public interface IContext
    {

        DbSet<User> UserContext { get; set; }
        DbSet<Child> ChildContext { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
