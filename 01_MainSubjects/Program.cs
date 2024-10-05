using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion


            #region String Değişkenler

            //string name;
            //name = "Eflal";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Abdullah";
            //customerSurname = "Selçuk";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Maltepe";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Gülsüm";
            //customerSurname = "Özcan";
            //customerPhone = "+90 500 600 70 80";
            //customerEmail = "test@gmail.com";
            //district = "Sütçüler";
            //city = "Isparta";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            #endregion


            #region Integer Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalHamburgerPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();     
        }
    }
}

#region Ek Bilgiler - Giriş ve Yazdırma Komutları

/* uygulama bize en başta "Program" isminde bir class verdi
 * bu class, uygulamanın en başta çalışacağı sınıftır
 * en başta verilen "using ifadeler" kullanacağım kodları barındıran kütüphanelerdir
 * namespace kısmında projenin adı yer alır
 * internal, bir erişim belirleyicidir
 * main bir metottur ve kodlarımızı main'in içine yazmamız gerekir
 * "write" bir metottur, bunun için solundaki mor küp bize ipucu verir
 * console.read(); komutu enter tuşuna basana kadar çıktıyı ekranda bekletir
 * bu komut kullanılmazsa çıktı anlık olarak ekrana gelir ve sonra kaybolur
 * write ifadesi çıktıyı yazdıktan sonra imleci hemen sağına koyar
 * writeline ise çıktıdan sonra imleci alt satıra bırakır
 * satırları toplu bir şekilde açıklama satırına dönüştürmek için comment out butonunu kullanıyoruz
 * ctrl+d imlecin bulunduğu satırı aşağı kopyalar */

#endregion

#region Ek Bilgiler - String Değişkenler

/* veriler üzerinde işlem yapabilmemi sağlar ve geçici olarak RAM'de tutulur.
 * tanımlanma biçimi: değişken_türü değişken_adı; 
 * yukarda string name; şeklinde tanımlama yaptığımda name'in altındaki yeşil çizgi,
 * bu değişkenin tanımlandığını ama henüz kullanılmadığını (çağrılmadığını) gösteriyor
 * değişkenler çağrılacağı zaman komutun içinde çift tırnak arasında yazılmaz
 * isimlendirme standartları değişken adlandırırken kullanılır
 * bunlardan biri camel case'dir -> ilk sözcüğün baş harfi küçük diğerlerinin baş harfi büyük ve arada boşluk yok
 * örn: string customerNameSurname;
 * değişken ismi açık ve anlaşılır olmalı, gerekirse uzun olabilir
 * bir satırda aynı türden birkaç değişken tanımlanabilir
 * programlamada hiyerarşik bir sıra vardır, aynı değişkene daha sonra başka atama yapılırsa
 * değişkenin değeri yapılan son atamanın değeri olur */

#endregion