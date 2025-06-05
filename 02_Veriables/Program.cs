using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //number = 4.85;
            ////Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, potatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //tomatoPrice = 6.88;
            //potatoPrice = 9.74;
            //Console.WriteLine("---- Elma Birim Fiyat: " + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyat: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyat: " + strawberryPrice);
            //Console.WriteLine("---- Domates Birim Fiyat: " + tomatoPrice);
            //Console.WriteLine("---- Patates Birim Fiyat: " + potatoPrice);
            //double appleGram, orangeGram,strawberryGram,tomatoGram,potatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //tomatoGram = 3.745;
            //potatoGram = 4.859;
            //double appletotalPrice = applePrice * appleGram;
            //double orangetotalPrice = orangePrice * orangeGram;
            //double strawberrytotalPrice = strawberryPrice * strawberryGram;
            //double tomatototalPrice = tomatoPrice * tomatoGram;
            //double potatototalPrice = potatoPrice * potatoGram;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Elma -" + "Birim Fiyat:" + applePrice + " - Gramaj: " + appleGram + "- Toplam Tutar: " + appletotalPrice + " TL"); 
            //Console.WriteLine("Alınan ürün: Portakal -" + "Birim Fiyat:" + orangePrice + " - Gramaj: " + orangeGram + "- Toplam Tutar: " + orangetotalPrice + " TL"); 
            //Console.WriteLine("Alınan ürün: Çilek -" + "Birim Fiyat:" + strawberryPrice + " - Gramaj: " + strawberryGram + "- Toplam Tutar: " + strawberrytotalPrice + " TL"); 
            //Console.WriteLine("Alınan ürün: Domates -" + "Birim Fiyat:" + tomatoPrice + " - Gramaj: " + tomatoGram + "- Toplam Tutar: " + tomatototalPrice + " TL"); 
            //Console.WriteLine("Alınan ürün: Patates -" + "Birim Fiyat:" + potatoPrice + " - Gramaj: " + potatoGram + "- Toplam Tutar: " + potatototalPrice + " TL");
            //double shoppingTotalPrice = appletotalPrice + orangetotalPrice + strawberrytotalPrice + tomatototalPrice + potatototalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Tutari: "+shoppingTotalPrice+ " TL");
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            //Console.WriteLine("***** Csharp Havayollari Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentity;
            //Console.Write("Yolcu adi: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu soyad: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("ilçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("TC kimlik Numarasi: ");
            //passengerIdentity = Console.ReadLine();
            //Console.WriteLine("Yolcu TC Kimlik numarasi: "+ passengerIdentity+"Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            //int shoesPrice, computerPrice, tvPrice, chairPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //tvPrice = 12000;
            //chairPrice = 5000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + tvCount * tvPrice + chairPrice * chairCount;
            //Console.WriteLine("Alışveriş Tutari: " + totalPrice + " TL");
            //double exam1, exam2,exam3,result;
            //Console.Write("Lütfen birinci sınavı Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınavı Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınavı Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız : "+result);
            Console.Write("Cinsiyet Giriniz:");
            char gender=char.Parse(Console.ReadLine());
            Console.Write("Seçtiğiniz Cinsiyet: "+gender);
            Console.Read();
        }
    }
}
