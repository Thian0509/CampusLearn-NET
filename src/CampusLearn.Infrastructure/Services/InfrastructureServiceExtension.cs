using CampusLearn.Application.Abstractions;
using CampusLearn.Application.Account;
using CampusLearn.Domain.Account;
using CampusLearn.Infrastructure.Config;
using CampusLearn.Infrastructure.Persistence;
using CampusLearn.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CampusLearn.Infrastructure.Services
{
    public static class InfrastructureServiceExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoSettings>(configuration.GetSection("Mongo"));
            services.AddSingleton<MongoContext>();
            services.AddSingleton<UserRepository>(); // design pattern, for external uses like files or database, but then you only see the facad of insert, display etc
            services.AddSingleton<TopicRepository>();
            services.AddSingleton<IUserService, UserService>(); // register tasks etc
            services.AddSingleton<ITopicService, TopicService>();
            services.AddTransient<IAccountFactory, AccountFactory>();
            services.AddTransient<AccountService>(); // Register the service that uses the factory

            return services;
        }
    }
}
