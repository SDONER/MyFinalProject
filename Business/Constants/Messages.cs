using Core.Entities.Concrate;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi :)";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda!!!";
        public static string ProductListed = "Ürünler Listelendi :)";
        public static string ProductCountOfCategoryError = "Bie kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExists = "Eklemek istediğiniz ürün ismi daha önce kaydedilmiştir!";
        public static string CategoryLimitExceded = "Category Limiti Aşıldı!";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kullanıcı kaydedildi :) ";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş bşarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
    
}
