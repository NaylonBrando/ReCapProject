﻿using System.Text;

namespace Core.Ultilities.Secuirty
{
    public class HashingHelper
    {
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash
            (string password, byte[] passwordHash, byte[] passwordSalt)

        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHast = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHast.Length; i++)
                {
                    if (computedHast[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void CreateCardNumberHash(string cardNumber, out byte[] cardNumberHash, out byte[] cardNumberSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                cardNumberSalt = hmac.Key;
                cardNumberHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(cardNumber));
            }
        }

        public static bool VerifyCardNumberHash(string cardNumber, byte[] cardNumberHash, byte[] cardNumberSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(cardNumberSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(cardNumber));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != cardNumberHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void CreateExpirationDateHash(string expirationDate, out byte[] expirationDateHash, out byte[] expirationDateSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                expirationDateSalt = hmac.Key;
                expirationDateHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(expirationDate));
            }
        }

        public static bool VerifyExpirationDateHash(string expirationDate, byte[] expirationDateHash, byte[] expirationDateSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(expirationDateSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(expirationDate));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != expirationDateHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void CreateCvvHash(string cvv, out byte[] cvvHash, out byte[] cvvSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                cvvSalt = hmac.Key;
                cvvHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(cvv));
            }
        }

        public static bool VerifyCvvHash(string cvv, byte[] cvvHash, byte[] cvvSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(cvvSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(cvv));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != cvvHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}