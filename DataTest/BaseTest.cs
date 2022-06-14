using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace DataTest
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
    }

    public class Dbteste : IDisposable
    {

        private string dataBaseName = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-", string.Empty)}";

        public ServiceProvider ServiceProvider { get; private set; }

        public Dbteste()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>(o =>
            o.UseSqlServer($"Persist Security Info=True;Server=.;DataBase=DbAPITest;Trusted_Connection=true;MultipleActiveResultSets=true"),
            ServiceLifetime.Transient
            );
            ServiceProvider = serviceCollection.BuildServiceProvider();
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureCreated();
            }   
        }
        public void Dispose()
        {
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}
