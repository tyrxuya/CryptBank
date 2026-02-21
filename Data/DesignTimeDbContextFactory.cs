using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CryptBankDbContext>
    {
        public CryptBankDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<CryptBankDbContext>()
                .UseNpgsql("Host=localhost;Port=5432;Database=cryptbank;Username=postgres;Password=1234")
                .Options;

            return new CryptBankDbContext(options);
        }
    }
}
