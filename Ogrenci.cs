//ogrenci no basekisi bagla yazdir
using System;
public class Ogrenci : BaseKisi
{
    public required string OgrenciNo { get; set; }
    public void OgrenciBilgileriYaz()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad} Ogrenci No: {OgrenciNo}");
    }
}