using Core.Business;
using Data;
using Data.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace View
{
    internal static class AppServices
    {
        public static IUserCredentialsBusiness UserCreds { get; private set; } = null!;
        public static CryptBankDbContext Db { get; private set; } = null!;

        public static void Init()
        {
            var cs = "Host=localhost;Port=5432;Database=cryptbank;Username=postgres;Password=1234";

            var options = new DbContextOptionsBuilder<CryptBankDbContext>()
                .UseNpgsql(cs)
                .Options;

            Db = new CryptBankDbContext(options);

            // apply migrations automatically
            Db.Database.Migrate();

            UserCreds = new UserCredentialsBusiness(Db);
        }
    }
}
