using Microsoft.Extensions.DependencyInjection;
using PayAPI.Application.ProcessPaymentApp;
using PayAPI.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayAPI.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddTransient<ICheapPaymentGatewayAppService, CheapPaymentGatewayAppService>();
            services.AddTransient<IExpensivePaymentGatewayAppService, ExpensivePaymentGatewayAppService>();
            services.AddTransient<IPremiumPaymentGatewayAppService, PremiumPaymentGatewayAppService>();
            return services;
        }
    }
}
