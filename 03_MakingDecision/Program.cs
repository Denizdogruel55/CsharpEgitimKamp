using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Lütfen Şifrenizi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlıs");
            //}

            //string capital, country;
            //Console.Write("Lütfen Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Lütfen Ülkeyi Giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler yanlış");
            //}

            //int number;
            //Console.Write("Sayi Giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Yanlis");
            //}
            //int exam1, exam2, exam3, average;
            //string result="hata";
            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalamasi: " + average);
            //if (average > 0 & average < 50)
            //{
            //    result = "vasat";
            //}
            //else if (average > 50 & average <= 70)
            //{
            //    result = "Orta";
            //}
            //else if (average > 70 & average <= 84)
            //{
            //    result = "İyi";
            //}
            //else if (average > 84)
            //{
            //    result = "Cok iyi";
            //}
            //Console.WriteLine(result);
            //string city;
            //Console.Write("Şehir Giriniz: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir yanlıs");
            //}

            //Console.Write("Kullanıcı adını Giriniz: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Hata");
            //}
            //else
            //{
            //    Console.WriteLine("Hosgeldiniz...");
            //}
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write("Lütfen 1.Sayiyi Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayiyi Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("Sonuc: " + result);
            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı Çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tek");

            //}
            //char team;
            //Console.Write("Takım Sembolu Giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");

            //}
            //else if (team == 'g' | team == 'G')
            //{

            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'b' | team == 'B') {
            //    Console.WriteLine("Beşiktaş");
            //}
            //Console.WriteLine("****** CSharp Egitim kampi Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-içecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------");
            //string item;
            //Console.Write("Lütfen Menu Seçimi Yapınız: ");
            //item = Console.ReadLine();
            //if (item == "1")
            //{
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //}
            //if (item == "2")
            //{
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbasi");
            //    Console.WriteLine("2-Ezogelin Çorbasi");

            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}
            //if (item == "3")
            //{
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");

            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}
            //if (item == "4")
            //{
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Ayran");

            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //}
            //if (item == "5")
            //{
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");

            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //}
            //Console.Write("Ay Seçimi Yapınız: ");
            //int monthNumber;
            //monthNumber=int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:
            //        Console.WriteLine("Hatali Giriş yapıldı");break;
            //}
            
            //int number1, number2, result;
            //Console.Write("Sayi 1: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Sayi 2:");
            //number2 = int.Parse(Console.ReadLine());
            //char işlem;
            //Console.Write("işlem seçiniz:");
            //işlem = char.Parse(Console.ReadLine());
            //switch (işlem)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuc:" + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuc:" + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuc:" + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuc:" + result); break;
            //    case '%':
            //        result = number1 % number2;
            //        Console.WriteLine("Sonuc:" + result);
            //        break;
            //    default: Console.WriteLine("hata"); break;


            //}

            //Console.Read();
        }
    }
}
