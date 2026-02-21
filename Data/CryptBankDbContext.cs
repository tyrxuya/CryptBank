using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class CryptBankDbContext : DbContext
    {
        public CryptBankDbContext(DbContextOptions<CryptBankDbContext> options) : base(options) {}

        public DbSet<UserCredentials> UserCredentials { get; set; }
    }
}
