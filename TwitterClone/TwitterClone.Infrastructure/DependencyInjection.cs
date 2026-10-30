using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwitterClone.Application.Interfaces;
using TwitterClone.Infrastructure.Repositories;

namespace TwitterClone.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Singletons because the repositories keep their data in memory.
            // Switch to scoped when they are backed by a real database (e.g. EF Core DbContext).

            ser
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITweetRepository, TweetRepository>();
            services.AddScoped<IBookmarkRepository, BookmarkRepository>();
            services.AddScoped<IFollowRepository, FollowRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IRetweetRepository, RetweetRepository>();

            return services;
        }
    }
}
