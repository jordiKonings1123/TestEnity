using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Model.Repositories.Configuration;
using Model.Repositories.Seeding;
namespace Model.Repositories
{
    public class TestEntityContext : DbContext
    {
        public static IConfigurationRoot configuration;
        private bool testMode = false;
        // ------
        // DbSets
        // ------
        public DbSet<Land> Genres { get; set; }
        public DbSet<Stad> Klanten { get; set; }
        public DbSet<Taal> Reservaties { get; set; }
        // ------------
        // Constructors
        // ------------
        public TestEntityContext() { }
        public TestEntityContext(DbContextOptions<TestEntityContext> options) : base(options) { }
        // -------
        // Logging
        // -------
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging
            (
            builder => builder.AddConsole()
            .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information)
            );
            return serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Zoek de naam in de connectionStrings section - appsettings.json
                configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName) //

                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();
                var connectionString = configuration.GetConnectionString("Test3");
                if (connectionString != null) // Indien de naam is gevonden
                {
                    optionsBuilder.UseSqlServer(
                    connectionString
                    , options => options.MaxBatchSize(150)); // Max aantal SQL commands die kunnen doorgestuurdworden naar de database//
                                                             //.UseLoggerFactory(GetLoggerFactory())

                    //.EnableSensitiveDataLogging(true);

                    // Toont de waarden van de parameters bij de logging

                    // .UseLazyLoadingProxies();

                }
            }
            else
            {
                testMode = true;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





            // Configurations
            // --------------
            modelBuilder.ApplyConfiguration(new LandConfiguration());
            modelBuilder.ApplyConfiguration(new StadConfiguration());
            modelBuilder.ApplyConfiguration(new TaalConfiguration());
            modelBuilder.ApplyConfiguration(new LandTaalConfiguration());

            modelBuilder.Entity<Land>().HasIndex(x => new { x.ISOLandCode }).IsUnique();

            // -------
            // Seeding
            // -------
            if (!testMode)
            {
                modelBuilder.ApplyConfiguration(new LandSeeding());
                modelBuilder.ApplyConfiguration(new StadSeeding());
                modelBuilder.ApplyConfiguration(new TaalSeeding());
                //modelBuilder.ApplyConfiguration(new LandTaalSeeding());
            }
        }
    }
}