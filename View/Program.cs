using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginView());

            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<CryptBankDbContext>()
                .UseNpgsql(connectionString)
                .Options;

            var db = new CryptBankDbContext(options);

            // автоматично създава/ъпдейтва базата
            db.Database.Migrate();
        }
    }
}