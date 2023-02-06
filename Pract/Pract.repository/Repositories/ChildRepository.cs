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
    public class ChildRepository : IDataRepository<Child>
    {
        IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> news = _context.ChildContext.Add(entity);

            await _context.SaveChangesAsync();
            return news.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.ChildContext.Remove(_context.ChildContext.FirstOrDefault(p => p.Id == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.ChildContext.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.ChildContext.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            var news = _context.ChildContext.Update(entity);
            await _context.SaveChangesAsync();
            return news.Entity;
        }
    }
}
