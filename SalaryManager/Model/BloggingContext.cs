using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace SalaryManager.Model
{
    public class BloggingContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeGroup> EmployeeGroups { get; set; }
        public DbSet<Chief> Chiefs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Hardcode
            optionsBuilder.UseSqlite("Data Source = salary_manager.db");
        }

        // For get Data Source from App.config
        static string GetConnectionStringByProvider(string providerName)
        {
           string returnValue = null;

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ProviderName == providerName)
                        returnValue = cs.ConnectionString;
                    break;
                }
            }
            return returnValue;
        }
    }
}
