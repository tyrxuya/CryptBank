using Core.Business;
using Core.DTO;
using Data.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Business
{
    public class UserCredentialsBusiness(CryptBankDbContext _dbContext) : IUserCredentialsBusiness
    {
        private readonly CryptBankDbContext dbContext = _dbContext;

        public void Add(UserCredentialsDTO dto)
        {
            if (dbContext.UserCredentials.Find(dto.Id) != null)
            {
                return;
            }

            dbContext.UserCredentials.Add(dto.ToEntity());
            dbContext.SaveChanges();
        }

        public UserCredentialsDTO? Find(UserCredentialsDTO dto)
        {
            return dbContext.UserCredentials.Find(dto.Id)?.ToDto();
        }

        public UserCredentialsDTO? FindByUsername(string username)
        {
            return dbContext.UserCredentials.FirstOrDefault(uc => uc.Username == username)?.ToDto();
        }

        public List<UserCredentialsDTO> GetAll()
        {
            return dbContext.UserCredentials.Select(uc => uc.ToDto()).ToList();
        }
    }
}
