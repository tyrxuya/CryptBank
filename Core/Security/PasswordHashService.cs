using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core.Security
{
    public sealed record PasswordHashResult(
        string Algo,
        int Iterations,
        string SaltB64,
        int DkLen,
        string HashB64
    );

    public static class PasswordHashService
    {
        public const string AlgoName = "PBKDF2-HMAC-SHA256";
        public const int DefaultDkLen = 32;
        public const int DefaultSaltBytes = 16;

        public static PasswordHashResult HashPassword(
            string password,
            int iterations,
            int dkLen = DefaultDkLen,
            int saltBytes = DefaultSaltBytes
        )
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password is required.");
            }
                
            if (iterations < 1)
            {
                throw new ArgumentException("Iterations must be >= 1.");
            }
                
            if (dkLen < 16)
            {
                throw new ArgumentException("dkLen is too small.");
            }
                
            if (saltBytes < 16)
            {
                throw new ArgumentException("Salt must be at least 16 bytes.");
            }
                
            byte[] salt = RandomNumberGenerator.GetBytes(saltBytes);

            byte[] dk = Rfc2898DeriveBytes.Pbkdf2(
                password: password,
                salt: salt,
                iterations: iterations,
                hashAlgorithm: HashAlgorithmName.SHA256,
                outputLength: dkLen
            );

            return new PasswordHashResult(
                Algo: AlgoName,
                Iterations: iterations,
                SaltB64: Convert.ToBase64String(salt),
                DkLen: dkLen,
                HashB64: Convert.ToBase64String(dk)
            );
        }

        public static bool VerifyPassword(
            string password,
            string saltB64,
            int iterations,
            int dkLen,
            string expectedHashB64
        )
        {
            byte[] salt = Convert.FromBase64String(saltB64);
            byte[] expected = Convert.FromBase64String(expectedHashB64);

            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(
                password: password,
                salt: salt,
                iterations: iterations,
                hashAlgorithm: HashAlgorithmName.SHA256,
                outputLength: dkLen
            );

            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }
    }
}
