
// Geriye değer döndürmeyen bir void metot.

//Ekrana sevdiğiniz bir şarkı sözünü yazdırsın.   


using System.Reflection.Metadata;

void SarkiSozuYazdir()
{
    Console.WriteLine("Benden bir tane daha yok");
}

SarkiSozuYazdir();



// Geriye tam sayı döndüren bir metot.

//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.


int kalan = RastgeleSayiVeKalan();
Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan:" + kalan);

static int RastgeleSayiVeKalan()
{
    Random rastgele = new Random();
    int sayi = rastgele.Next(1, 101);
    Console.WriteLine("Üretilen rastgele sayı:" + sayi);
    return sayi % 2;
}




// Parametre alan ve geriye değer döndüren bir metot

//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.


static void Main()
{

    int sonuc = Carpim(5, 10);
    Console.WriteLine("Çarpım sonucu: " + sonuc);
}

// Parametre olarak iki sayı alıp çarpımını döndüren metot
static int Carpim(int sayi1, int sayi2)
{
    return sayi1 * sayi2;  // İki sayının çarpımını geri döndür
}

Main();



// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

void SelamVerme()
{
    Console.WriteLine("Lütfen adınızı giriniz.");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen soyadınızı giriniz.");
    string surname = Console.ReadLine();
    Console.WriteLine("Hoş geldiniz" + " " + name + " " + surname);
}
SelamVerme();