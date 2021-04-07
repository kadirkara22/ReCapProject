using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
  public static  class Messages
    {
        public static string CarAdded = "Ürün Eklendi";
        public static string CarNameInvalid= "Ürün ismi geçersiz";
        public static string CarsListed = "ürünler listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";

        public static string MaintenanceTime = "Sistem bakımda";

        
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renkler listelendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "kullanıcı güncellendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserSelected = "Kullanıcı seçildi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "müşteriler listelendi";
        public static string CustomerSelected = "Müşteri seçildi";

        public static string RentalAdded = "Kiralama bilgileri eklendi";
        public static string RentalDeleted = "Kiralama bilgileri silindi";
        public static string RentalListed = "Kiralama bilgileri listelendi";
        public static string RentalUpdated = "Kiralama bilgiler Güncellendi";
        public static string RentalSelected = "Kiralanan arac seçildi";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted= "Araba resmi silindi";
        public static string CarImageUpdated= "Araba resmi güncellendi";
        public static string CarImageListed= "Araba resimleri listelendi";
        public static string NotRentalAddOrUpdate = "Bu araba kiralanamaz";
        public static string FailedCarAdded = "Bir araba 5'den fazla resme sahip olamaz.";


        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string EmailListed="Mailler listelendi";
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string BrandAndColorListed = "Marka ve Renk listelendi";
        public static string added = "Eklendi";
    }
}
