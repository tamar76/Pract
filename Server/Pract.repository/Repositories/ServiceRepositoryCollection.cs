using Microsoft.Extensions.DependencyInjection;
using Pract.Repository.Entities;
using Pract.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Repository.Repositories
{
    public static class ServiceRepositoryCollection
    {
        public static  void AddRepository(this IServiceCollection service)
        {
                service.AddScoped<IDataRepository<User>, UserRepository>();
                
        }
    }
}
