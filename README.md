# PatikaWeek4PracticePolymorphism

Bu proje, polimorfizm kullanarak farklı geometrik şekillerin alanlarını hesaplayan bir uygulamadır. Projede Kare, Dikdörtgen ve Dik Üçgen sınıfları bulunmaktadır ve her biri `BaseGeometrikSekil` sınıfından türemiştir.

Kullanım
Projeyi çalıştırmak için Program.cs dosyasını açın ve çalıştırın. Main metodu aşağıdaki adımları içerir:

Kare nesnesi oluşturma ve alan hesaplama
Dikdortgen nesnesi oluşturma ve alan hesaplama
DikUcgen nesnesi oluşturma ve alan hesaplama

Kare kare = new Kare();
kare.Width = 6;
kare.Height = 6;
kare.AreaCalculation();

Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.Width = 8;
dikdortgen.Height = 3;
dikdortgen.AreaCalculation();

DikUcgen dikUcgen = new DikUcgen();
dikUcgen.Width = 7;
dikUcgen.Height = 9;
dikUcgen.AreaCalculation();


Sınıflar
BaseGeometrikSekil
BaseGeometrikSekil sınıfı, tüm geometrik şekillerin temel özelliklerini ve metotlarını içerir.

Özellikler:

Width: Genişlik
Height: Yükseklik
Metotlar:

AreaCalculation(): Şeklin alanını hesaplar ve ekrana yazdırır.
Kare
Kare sınıfı, BaseGeometrikSekil sınıfından türetilmiştir ve AreaCalculation metodunu override eder.

Dikdortgen
Dikdortgen sınıfı, BaseGeometrikSekil sınıfından türetilmiştir ve AreaCalculation metodunu override eder.

DikUcgen
DikUcgen sınıfı, BaseGeometrikSekil sınıfından türetilmiştir ve AreaCalculation metodunu override eder. Dik üçgenin alanını (Width * Height) / 2 formülü ile hesaplar.
