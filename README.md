# InheritincaProject

Bu proje, C# dilinde kalıtım (inheritance) konusunu örnekleyen basit bir uygulamadır. Projede `BaseKisi`, `Ogrenci` ve `Ogretmen` sınıfları bulunmaktadır.

## İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Sınıflar](#sınıflar)
  - [BaseKisi](#basekisi)
  - [Ogrenci](#ogrenci)
  - [Ogretmen](#ogretmen)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Kurulum

Projeyi yerel makinenize klonlamak için aşağıdaki komutu kullanabilirsiniz:

```sh
git clone https://github.com/ahmetemreari/InheritincaProject.git
##
```

## Kullanım

Projeyi çalıştırmak için Visual Studio veya Visual Studio Code gibi bir IDE kullanabilirsiniz. Projeyi açtıktan sonra `Program.cs` dosyasını çalıştırarak uygulamayı başlatabilirsiniz.

## Sınıflar

### BaseKisi

`BaseKisi` sınıfı, `Ad` ve `Soyad` özelliklerini içerir ve bu bilgileri yazdıran bir metot sağlar.

```csharp
public class BaseKisi
{
    public required string Ad { get; set; }
    public required string Soyad { get; set; }

    public void AdSoyadYaz()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad}");
    }
}
```

### Ogrenci

`Ogrenci` sınıfı, `BaseKisi` sınıfından türetilmiştir ve ek olarak `OgrenciNo` özelliğini içerir. Öğrenci bilgilerini yazdıran bir metot sağlar.

```csharp
public class Ogrenci : BaseKisi
{
    public required string OgrenciNo { get; set; }

    public void OgrenciBilgileriYaz()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad} Ogrenci No: {OgrenciNo}");
    }
}
```

### Ogretmen

`Ogretmen` sınıfı, `BaseKisi` sınıfından türetilmiştir ve ek olarak `Maas` özelliğini içerir. Öğretmen bilgilerini yazdıran bir metot sağlar.

```csharp
public class Ogretmen : BaseKisi
{
    public decimal Maas { get; set; }

    public void OgretmenBilgileriYaz()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad} Maaş: {Maas}");
    }
}
```

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir `fork` yapın ve değişikliklerinizi bir `pull request` ile gönderin. Her türlü katkı memnuniyetle karşılanır!

1. Projeyi `fork`layın
2. Yeni bir dal (`branch`) oluşturun: `git checkout -b feature/isim`
3. Değişikliklerinizi `commit`leyin: `git commit -am 'Yeni özellik ekle'`
4. Dalınızı `push`layın: `git push origin feature/isim`
5. Bir `pull request` oluşturun

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakabilirsiniz.
```

