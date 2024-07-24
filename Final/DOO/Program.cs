using DOO.Dao;
using DOO.Models;
using DOO.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace DOO
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        private static string _dbFileName = "productos.db";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            DatabaseDbContext juan = new DatabaseDbContext();

            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
            Application.Run(new PersonaForm());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseDbContext>(options =>
                options.UseSqlite(connectionString: @$"Filename={_dbFileName}", sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                }));

            services.AddScoped<IProducto, ProductosStore>();
            services.AddScoped<ProductosStore>();
            services.AddScoped<IPersona, PersonaDB>();
            services.AddScoped<PersonaDB>();
            services.AddScoped<Direccion>();
        }
    }
}