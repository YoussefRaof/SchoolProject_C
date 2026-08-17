using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Repositories;
using SchoolProject.Infrastructure.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfraDI(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepostiory>();
            return services;
        }
    }
}
