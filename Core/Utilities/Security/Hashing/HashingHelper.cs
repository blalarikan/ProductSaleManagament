using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Core.Utilities.Security.Hashing
{

    //appsettings e JSON token için gerekli parametreleri ekledik. Core altında 3 farklı klasör oluşturup devam ediyoruz.
    public class HashingHelper
    {

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {

            //out --- dışarıya bu değeri çıkart anlamına geliyor. 

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            //bu kod verdiğimiz password değerine göre bir salt ve hash değeri yaratıyor
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) //kullanıcının girdiği parola ile bizim hash ve salt değerlerinin karşılaştırıldığı metot
        {
            using
                (var hmac =
                 new System.Security.Cryptography.HMACSHA512(
                     passwordSalt)) // istediği key değer aslında password saltımız
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

    }
}
