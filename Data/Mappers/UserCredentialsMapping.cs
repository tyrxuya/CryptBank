using Core.DTO;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappers
{
    public static class UserCredentialsMapping
    {
        public static UserCredentialsDTO ToDto(this UserCredentials entity)
            => new UserCredentialsDTO
            {
                Id = entity.Id,
                Username = entity.Username,
                Algo = entity.Algo,
                Iterations = entity.Iterations,
                SaltB64 = entity.SaltB64,
                DkLen = entity.DkLen,
                HashB64 = entity.HashB64
            };

        public static UserCredentials ToEntity(this UserCredentialsDTO dto)
            => new UserCredentials
            {
                Id = dto.Id,
                Username = dto.Username,
                Algo = dto.Algo,
                Iterations = dto.Iterations,
                SaltB64 = dto.SaltB64,
                DkLen = dto.DkLen,
                HashB64 = dto.HashB64
            };

        public static void ApplyTo(this UserCredentialsDTO dto, UserCredentials entity)
        {
            entity.Username = dto.Username;
            entity.Algo = dto.Algo;
            entity.Iterations = dto.Iterations;
            entity.SaltB64 = dto.SaltB64;
            entity.DkLen = dto.DkLen;
            entity.HashB64 = dto.HashB64;
        }
    }
}
