//METOTLAR - METHODS
// C# dilinde metotlar, belirli bir işlevi yerine getiren kod bloklarıdır.
// Metotlar, kodunuzu daha düzenli ve yeniden kullanılabilir hale getirir.
// Aşağıda bir metot tanımlama ve çağırma örneği bulunmaktadır:
// Metot Tanımlama
// void ifadesi, metotun geriye değer döndürmediğini belirtir.
// Metot adı ve parametre listesi parantez içinde belirtilir.
// Metot Çağırma

using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

string firstName = "John";

string lastName = "Doe";

Console.WriteLine("First Name :"+firstName);

Console.WriteLine("Last Name :"+lastName);

firstName = "Muhammed Emin";
lastName = "Saka";

GetFullName();

SetFullName(); // DEĞER DÖNDÜ AMA EKRANDA ÇIKTI OLMAZ Kİ BUNU KULLANMAK İSTİYORSAN
               // YANİ PARAMETRESİZ DEĞER DÖNDÜREN METODU KULLANMAK İSTİYORSAN
               // GLOBALDE DEĞİŞKENE ATABİLİRSİN.


void GetFullName()
{

    string fullName = $"{firstName} {lastName}";

    Console.WriteLine("Full Name :" +fullName);
    Console.WriteLine("Deneme1");
    Console.WriteLine("Deneme2");
    Console.WriteLine("Deneme3");

}

string SetFullName()
{
    return $"{firstName} {lastName}";
}

// Metot çağrıldığında, metot adı ve gerekli parametreler parantez içinde belirtilir.
// Metotlar, kodunuzu daha düzenli ve okunabilir hale getirir.
// Ayrıca, aynı metodu birden fazla kez çağırarak kod tekrarını önler.

void EkranaYaz(string mesaj)
{

   
    Console.WriteLine(mesaj);

}

int sayi1 = 15;
int sayi2 = 25;

string note = $"Sayi 1 + Sayi 2  => {sayi1} + {sayi2} =  {sayi1 + sayi2}";

EkranaYaz(note);

StrTopla(sayi1, sayi2);

int sayilarıntoplamı = topla(sayi1,sayi2);
Console.WriteLine(sayilarıntoplamı);
int topla(int a, int b)
{
    return a + b;
}

string StrTopla(int a, int b)
{
    return (a+b).ToString();


}

int sonuc = topla(sayi1 , sayi2);

EkranaYaz(sonuc.ToString());


int[] numbers = [1,2,3,4,5,6,7,8,9,10];



void CiftYazdirParametreli(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.WriteLine(array[i]);
        }
    }
}


void CiftYazdirParametresiz()
{

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {

            Console.WriteLine(numbers[i]);


        }



    }


}


Console.WriteLine("PARAMETRELİ");

CiftYazdirParametreli(numbers);

Console.WriteLine("PARAMETRESİZ");

CiftYazdirParametresiz();

// KARESİNİ AL UYGULAMASI :

 int karesiniAl(int sayi)
{

    return sayi * sayi;

   
}

int sayinınKaresi = karesiniAl(sayi2);

Console.WriteLine(sayinınKaresi);




//1.Parametresiz ve Geriye Değer Döndürmeyen (En Bağımsızlar)
//Bu metotlar kimseye muhtaç değildir, kimseden bir şey istemez ve işi bitince size bir şey vermez.
//Sadece "git şu işi yap" dersin, yapar.

//Günlük Hayat Örneği: Bir alarmın çalması. Düğmesine basarsın, sadece ses çıkarır.

//Kod Örneği:
void MerhabaDe()
{
    Console.WriteLine("Selamlar!");
}
// Çağrılışı: MerhabaDe();


MerhabaDe();

//2.Parametreli ve Geriye Değer Döndürmeyen (Emir Erleri)
//Bu metotlara "şunu al ve onunla şu işi yap" dersin. Girdi alırlar ama çıktı üretmezler, sadece işi tamamlarlar.

//Günlük Hayat Örneği: Birine "Bu mektubu çöpe at" demek. Mektubu (parametre) verirsin,
//o sadece çöpe atar, sana geri bir şey getirmez.

//Kod Örneği:
void IsmiEkranaYaz(string isim)
{
    Console.WriteLine("Hoş geldin, " + isim);
}

IsmiEkranaYaz("MUHAMMED BABA");


//3.Parametresiz ve Geriye Değer Döndüren (Haber Kaynakları)
//Bu metotlar dışarıdan bir bilgiye ihtiyaç duymazlar ama işleri bittiğinde sana bir "cevap/veri" getirirler.

//Günlük Hayat Örneği: Birine "Saat kaç?" diye sormak. Ona bir bilgi vermezsin, o sana saati (veri) söyler.

//Kod Örneği:

string GununMesaji()
{
    return "Bugün kodlama için harika bir gün!";
}
// Çağrılışı: string mesaj = GununMesaji();


GununMesaji();



//4.Parametreli ve Geriye Değer Döndüren (Fabrikalar)
//En yetenekli olanlardır. "Şu malzemeleri (parametreleri) al, işle ve bana sonucu (return) getir" dersin.

//Günlük Hayat Örneği: Kahve makinesi. İçine su ve kahve koyarsın (parametre), o sana sıcak bir kahve (sonuç) döndürür.

//Kod Örneği:
int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
// Çağrılışı: int sonuc = Topla(10, 20);


Console.WriteLine(Topla(sayi1, sayi2)); // En sondaki çift paranteze dikkat!