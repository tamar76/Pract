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

        public async Task<User> AddAsync(User entity)
        {
            EntityEntry<User> news = _context.UserContext.Add(entity);

            await _context.SaveChangesAsync();
            return news.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.UserContext.Remove(_context.UserContext.FirstOrDefault(p => p.Id == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.UserContext.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.UserContext.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            var news = _context.UserContext.Update(entity);
            await _context.SaveChangesAsync();
            return news.Entity;
        }
    }
}
