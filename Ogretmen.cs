// maaş
using System;
public class Ogretmen : BaseKisi
{
    public decimal Maas { get; set; }
    public void MaasYaz()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad} Maas: {Maas}");
    }
}