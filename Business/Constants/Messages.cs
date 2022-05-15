using Core.Entities.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{ 
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime= "Bakım saati";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Ürün adedi bu kategori için uygun değildir.";
        public static string ProductNameAlreadyExists="Bu kategoride böyle bir ürün ismi mevcuttur.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenememektedir.";
        public static string AuthorizationDenied="Yetkiniz yoktur.";
        public static string  UserRegistered="Kayıt başarılı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Bu kullanıcı zaten var.";
        public static string AccessTokenCreated="Erişim tokenı oluşturuldu.";
    }
}
//publicler pascal case ile büyük harfle yazılır.
