using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün Ekelendi";

        public static string CarDeleted = "Ürün Silindi";

        public static string CarUpdated = "Ürün Güncellendi";


        public static string CarNameInvalid = "Ürün İsmi Geçersizdir";

        public static string MaintenanceTime = "Sistem Bakımda";

        public static string CarListed = "Ürün Listelendi";

        public static string CarNotDelivered = "Araç Teslim Edilmedi";
        public static string ImageLimit = "Görsel Ekleme Limiti Doldu";
        public static string ImageUpdate = "Görsel Güncellendi";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kayıt Oldu";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
