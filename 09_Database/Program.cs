using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace _09_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Urun-kategori Bilgi Sistemi ******");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Lütfen Getirmek istediğiniz Tablo numarasını Giriniz: ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Menü seçimi yapınız: ");
            string tablenumber=Console.ReadLine();
            Console.WriteLine("----------------------------------");
            SqlConnection sqlConnection = new SqlConnection("Data Source=DENIZ;Initial Catalog=CsharpEgitimKampiDB;Integrated Security=True;");
           
             sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLCATEGORY", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut);
            DataTable tbl=new DataTable();
           sqlDataAdapter.Fill(tbl);
            foreach(DataRow item in tbl.Rows)
            {
                foreach(var veri in item.ItemArray)
                {
                    Console.Write(veri.ToString());
                }
                Console.WriteLine();
            }
            sqlConnection.Close();

            Console.Read();

        }
    }
}
