using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";

        public static string MaintenanceTime = "Sisterm bakımda";
        public static string ProductListed = "Ürünler listelendi ";

        public static string ProductCountOfCategoryError = "bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten mevcut";

        public static string CategoryCountExceeded = "Kategori sayısı aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "parola Hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
    
