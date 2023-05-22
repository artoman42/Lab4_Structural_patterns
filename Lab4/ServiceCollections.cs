using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace UIL
{
    public static class ServiceCollections
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddTransient<IRunner, Runner>();
            serviceDescriptors.AddTransient<IMenuBuilder, MenuBuilder>();
            return serviceDescriptors;

        }
    }
}
