using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{ 
    class Program
    { 
        static void Main(string[] args)
        {
           // Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            SelamVer(isim:"Ayşe");

            int sonuc = Topla(3,5);

            //Diziler /Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];//bu şekilde yapılırsa yeni bir referans tanımlamış oluyoruz ve ilk 3 elemanı boş, 4. elemanı İlker olan bir değer tanımlamış oluyor
            ogrenciler[3] = "İlker";



            for (int i = 0; i < ogrenciler.Length;i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1; //sehirler2 yi sehirler1 i ata değil sehirler2 nin referansı sehirler1 e eşitle demek. yani sehirler2 nin tuttuğu bilgiler sehir1 in tuttuğu bilgiler diyoruz. sehirler1 deki ilk eleman adana olarak değiştiğinde sehirler2 de aynı referansa gittiği için o da 'Adana' olur
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.NationalIdentity = 123;
            person1.DateOfBirthYear = 1985;

            Person person2 = new Person();
            person2.FirstName = "Murat";


            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1; //sayi2=10
            sayi1 = 30;

            //string referans tipidir 

            foreach(string sehir in sehirler1) 
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };//referans derdini ortadan kaldırıyor
            yeniSehirler1.Add("Adana1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //void metotlar sadece işlemi yapar değer döndürmez
        static void SelamVer(string isim = "isimsiz") //default parametre->isimsiz
        {
            Console.WriteLine("Merhaba"+ isim);
        }

        static int Topla(int sayi1=5,int sayi2=10) //parametre vermezse standart bu değerleri kullanır
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc.ToString());
            return sonuc;
        }

         

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;


            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.ReadLine();
        }
    }
    class Vatandas
    {
        //string ad = "Engin";
        //string soyad = "Demiroğ";
        //int dogumYili = 1985;
        //long tcNo = 12345678910;

        //pascal casing-->kelimelerin ilk harfi büyük olur. class property metotlar bu şekilde olur
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }

}