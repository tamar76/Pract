using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pract.Repository.Entities;
using Pract.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Repository.Repositories
{
    public class UserRepository : IDataRepository<User>
    {
        IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddAsync(List<User> entities)
        {
            List<User> news= new List<User>();
            foreach (User item in entities)
            {
                news.Add(_context.UserContext.Add(item).Entity);

            }
            await _context.SaveChangesAsync();
            return news;
        }

       
   
    }
}
