using Microsoft.EntityFrameworkCore;
using Pract.Repository.Entities;
using Pract.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Repository
{
    public class Context:DbContext,IContext
    {
        public DbSet<User> UserContext { get; set; }
        public DbSet<Child> ChildContext { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localDb)\\msSQLlocalDb;Initial Catalog=liftProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
