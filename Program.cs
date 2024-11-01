using System;
class Program
{
    static void Main()
    {
        //öğrenci oluştur değer ata
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ali",
            Soyad = "Veli",
            OgrenciNo = "123"
        };
        //Öğrenci  yazdır felan
        System.Console.WriteLine("Öğrenci Bilgileri");
        ogrenci.OgrenciBilgileriYaz();
        //öğretmen oluştur değer ata
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Ayşe",
            Soyad = "Fatma",
            Maas = 5000
        };
        //Öğretmen yazdır felan
        System.Console.WriteLine("Öğretmen Bilgileri");
        ogretmen.MaasYaz();
        Console.ReadKey();  

    }
}