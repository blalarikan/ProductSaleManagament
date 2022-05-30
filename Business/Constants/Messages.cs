using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = " Bakım saatidir";

        public static string ProductListed = "Ürünler listelendi";

        public static string AuthorizationDenied = "AuthorizationDenied";
        public static string UserRegistered = "Kullanıcı kayıt edildi";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "parola hatalı";
        public static string SuccessfulLogin = "giriş başarılı";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "access token oluşturuldu";
    }
}
