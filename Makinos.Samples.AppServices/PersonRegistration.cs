using Makinos.Samples.BusinessAccessLayer.Implementations;
using Makinos.Samples.BusinessAccessLayer.Interfaces;
using Makinos.Samples.DataAccessRepository.Implementations;
using Makinos.Samples.DataAccessRepository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makinos.Samples.AppServices
{
    public static class PersonRegistration
    {
        public static IServiceCollection PersonScopedRegistration(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();
            return services;
        }
    }
}
