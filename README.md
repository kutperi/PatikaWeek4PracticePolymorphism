# Geometrik Şekil Alan Hesaplama

Bu repo, C# dilinde polimorfizm kullanarak geometrik şekillerin alanını hesaplayan bir uygulama içermektedir. Bu projede, temel bir geometrik şekil sınıfı oluşturulmuş ve bu sınıftan türeyen kare, dikdörtgen ve dik üçgen sınıfları yer almaktadır.

## İçindekiler

- [Genel Bakış](#genel-bakış)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kullanım](#kullanım)

## Genel Bakış

Bu proje, C# dilinde polimorfizm kavramını göstermek için hazırlanmıştır. `BaseGeometrikSekil` isimli bir temel sınıf ve bu sınıftan türetilmiş `Kare`, `Dikdortgen` ve `DikUcgen` sınıflarını içermektedir. Her bir sınıf, `AreaCalculation` metodunu kendi alan hesaplamasını yapmak üzere geçersiz kılmaktadır.

## Kullanılan Teknolojiler

- .NET Core

## Kullanım

Projede iki ana dosya bulunmaktadır:

1.) BaseGeometrikSekil.cs: Bu dosyada, temel geometrik şekil sınıfı ve bu sınıftan türeyen alt sınıflar yer almaktadır.

namespace PatikaWeek4PracticePolymorphism
{
    public class BaseGeometrikSekil // Creating a new class
    {
        public double Width { get; set; } // Defining properties
        public double Height { get; set; }

        public virtual void AreaCalculation() // Creating a virtual method that calculates area
        {
            Console.WriteLine($"Verilen şeklin alanı --> {Width * Height}");
        }
    }

    public class Kare : BaseGeometrikSekil // Creating a new class that inherits from base class
    {
        public override void AreaCalculation() // Overriding first method for Kare class
        {
            Console.WriteLine($"Karenin alanı --> {Width * Height}");
        }
    }

    public class Dikdortgen : BaseGeometrikSekil // Creating a new class that inherits from base class
    {
        public override void AreaCalculation() // Overriding first method for Dikdortgen class
        {
            Console.WriteLine($"Dikdörtgenin alanı --> {Width * Height}");
        }
    }

    public class DikUcgen : BaseGeometrikSekil // Creating a new class that inherits from base class
    {
        public override void AreaCalculation() // Overriding first method for DikUcgen class
        {
            Console.WriteLine($"Dik üçgenin alanı --> {(Width * Height) / 2}");
        }
    }
}

2.) Program.cs: Bu dosyada, Main metodu yer almakta ve oluşturulan sınıfların kullanımı gösterilmektedir.

using PatikaWeek4PracticePolymorphism;

Kare kare = new Kare(); // Creating an instance of Kare object

// Setting properties
kare.Width = 6; 
kare.Height = 6;

// Display area information
kare.AreaCalculation();

Dikdortgen dikdortgen = new Dikdortgen(); // Creating an instance of Dikdortgen object

//Setting properties
dikdortgen.Width = 8;
dikdortgen.Height = 3;

// Display area information
dikdortgen.AreaCalculation();

DikUcgen dikUcgen = new DikUcgen(); // Creating an instance of DikUcgen object

//Setting properties
dikUcgen.Width = 7;
dikUcgen.Height = 9;

//Display area information
dikUcgen.AreaCalculation();
