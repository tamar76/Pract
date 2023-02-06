using Microsoft.Extensions.DependencyInjection;
using Pract.Repository.Repositories;
using Pract.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pract.common.DTO_s;
using Pract.Services.Entities;

namespace Pract.Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddRepository();
            service.AddScoped<IService<UserDTO>, UserService>();
            service.AddScoped<IService<ChildDTO>,ChildService>();
            service.AddSingleton<IContext, Context>();
            service.AddAutoMapper(typeof(MappingProfile));

            return service;

        }
    }
}
