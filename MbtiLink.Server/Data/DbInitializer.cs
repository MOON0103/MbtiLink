using MbtiLink.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace MbtiLink.Server.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Users.Any())
                {
                    return;
                }

                var users = new User[]
                {
                    new User { Name = "Alice" },
                    new User { Name = "Bob" }
                };

                foreach (var user in users)
                {
                    context.Users.Add(user);
                }
                context.SaveChanges();
            }
        }
    }
}
