// property ad, soyad
// metot : AD ve soyadı yazdır
using System;
public class BaseKisi
{
    public required string Ad { get; set; }
    public required string Soyad { get; set; }
    public void AdSoyadYaz()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad}");
    }
}