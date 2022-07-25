using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Conctrete;
using Core.Infrastructure.Abstract;
using Core.Infrastructure.Concrede;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Entity;
using DataAccessLayer.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Autofac.MicrosoftIoC
{
    public static class AddServices
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityRepository<,>), typeof(EntityRepositoryBase<,>));
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddSingleton<IEmployeeDal, EfEmployeeRepository>();


            var mapperConfiguration = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapProfile());
            });
 
                
            IMapper  mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
