// See https://aka.ms/new-console-template for more information
//Değişkenler
//ValueTypes - Değer Tipleri
//Sayısal Tam sayı değerlerini tutan veri tipleri
//Btye => 0 - 255 arasında değer alır. 0000 0010 => (0 * 2^3 + 0 * 2^2 + 1 * 2^1 + 0 * 2^0)
//sbyte => -128 ile 127 arası değerler alır
//short => -32768 ile 32767 arası değer alır
//ushort => 0 ile 65535 arası değer alır
//int => -2147483648 ile 2147483647
//uint => 0 ile 4294967295

//Değişken oluşturma kuralları
//değişkenintürü değişkeneverilecekisim;


//camelCase => Değişken ismi birden fazla kelimeden oluşuyorsa yani adSoyad, dogumTarihi, toplamOdenecekTutar ,firstName, lastName, birthDate
//ilk kelimenin ilk harfi küçük sonra gelen her kelimenin ilk harfi büyük olacak şekilde

//PascalCase => Değişken ismi birden fazla kelimeden oluşuyorsa AdSoyad, DogumTarihi, ToplamOdenecekTutar ,FirstName, LastName, BirthDate
//her kelimenin ilk harfi büyük olacak şekilde

//Snake_Case => Değişken ismi birden fazla kelimeden oluşuyorsa ad_soyad, dogum_tarihi, toplam_odenecek_tutar ,first_name, last_name, birth_date
//her kelimenin arasına alt tire eklenir.
//
//Kebap-Case => Değişken ismi birden fazla kelimeden oluşuyorsa ad-soyad, dogum-tarihi, toplam-odenecek-tutar ,first-name, last-name, birth-date
//her kelimenin tire eklenir.

//DEĞER TİPLERİ
byte yas = 16;
byte minByte = byte.MinValue;
byte maxByte = byte.MaxValue;
Console.WriteLine("BYTE DEĞERLERİ");

Console.WriteLine("Değişken :  {0}\nMinumum : {1}\nMaksimum : {2}",yas,minByte,maxByte);

Console.WriteLine($"Değişken : {yas}\nMinumum : {minByte}\nMaksimum : {maxByte}");

Console.WriteLine("*********************************");

Console.WriteLine("SYBTE DEĞERLERİ");
sbyte degree = -65;
sbyte minSybte = sbyte.MinValue;
sbyte maxSybte = sbyte.MaxValue;

Console.WriteLine("Değişken : {0}\nMinumum : {1}\nMaksimum : {2}",degree,minSybte,maxSybte);
Console.WriteLine($"Değişken : {yas}\nMinumum : {minSybte}\nMaksimum : {maxSybte}");

Console.WriteLine("*********************************");

Console.WriteLine("SHORT DEĞERLERİ");
short number1 = -1658;
short minShort = short.MinValue;
short maxShort = short.MaxValue;

Console.WriteLine("Değişken :  {0} \nMinumum : {1}\nMaksimum : {2}",number1,minShort,maxShort);

Console.WriteLine($"Değişken : {number1}\nMinumum : {minShort}\nMaksimum : {maxByte}");

Console.WriteLine("**************************");


Console.WriteLine("USHORT DEĞERLERİ");
ushort number2 = 1658;
ushort minUShort = ushort.MinValue;
ushort maxUShort = ushort.MaxValue;

Console.WriteLine("Değişken : {0}\nMinumum : {1}\nMaksimum : {2}",number2,minUShort,maxUShort);

Console.WriteLine($"Değişken : {number2} \n Minumum {minUShort}\nMaksimum : {maxUShort}");

Console.WriteLine("*************************");

Console.WriteLine("İNT DEĞERLERİ");
int population = 80000000;
 int minInt = int.MinValue;
int maxInt = int.MaxValue;

Console.WriteLine("Değişken : {0}\nMinumum : {1}\nMaksimum {2}",population,minInt,maxInt);
Console.WriteLine($"Değişken : {population}\n Minumum {minInt}\nMaksimum {maxInt}");
Console.WriteLine("**************************");

Console.WriteLine("UİNT DEĞERLERİ");
uint worldPopulation = 60000000;
uint minUint = uint.MinValue;
uint maxUint = uint.MaxValue;

Console.WriteLine("Değişken : {0}\nMinumum : {1}\nMaksimum {2}",worldPopulation,minUint,maxUint);
Console.WriteLine($"Değişken : {worldPopulation}\n Minumum : {minUint}\nMaksimum : {maxUint}");
Console.WriteLine("***********************");

long longNumber = 914091234924;
long minLong = long.MinValue;
long maxLong = long.MaxValue;

Console.WriteLine("Değişken : {0}\nMinumum : {1}\nMaksimum : {2}",longNumber,minLong,maxLong);
Console.WriteLine($"Değişken : {longNumber}\nMinumum : {minLong}\nMaksimum : {maxLong}");
Console.WriteLine("***************************************");


float gram = 5.824f; // FLOATTA SAYININ YANINA "F" KOYMAK ZORUNDASIN VE ONDALIKLI İFADELER VİRGÜL DEĞİL NOKTAYLA AYRILIYOR.
double gram2 = 2.494; // DOUBLEDA SAYININ YANINA D KOYMAK ZORUNDA DEĞİLSİN KOYSANDA OLUR KOYMASANDA OLUR.
decimal gram3 = 24242.2232m; // DECIMALDA FLOAT GİBİ SAYININ YANINA "M" KOYMAK ZORUNDASIN.

Console.WriteLine($"Değişken : {gram}\nMinumum : {float.MinValue}\nMaksimum : {float.MaxValue}");

Console.WriteLine("**************************");

Console.WriteLine($"Değişen : {gram2}\n Minumum : {double.MinValue}\nMaksimum : {double.MaxValue}");

Console.WriteLine("***************************");

Console.WriteLine($"Değişken : {gram3}\n Minumum : {decimal.MinValue}\nMaksimum : {decimal.MaxValue}");

bool varMi = false;

bool dogruMu = true;

bool yokMu = true; // Değişken isimlendirmesi olumlu olarak oluşturulmalı.

Console.WriteLine(varMi + "" + dogruMu);

char karakter1 = 'a';
char karakter2 = 'A';

Console.WriteLine((int)karakter1 + "\n" + (int)karakter2);

// REFERANS TİPLER

string name = "akın";
string lastname = "Cengiz";

int sayi1 = 5;
int sayi2 = sayi1;

sayi2 = sayi2 + 23;

sayi1 = 98;

Console.WriteLine($"Sayı 1 = {sayi1}\n Sayı 2  = {sayi2}");

int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (var item in numbers)
{
    Console.WriteLine("Numbers Dizisi :"  + item);

}

int [] numbers2 = numbers;
foreach (var item in numbers2)
{

    Console.WriteLine( "Numbers 2 Dizisi :" + item);

}

numbers[5] = 69;
numbers[0] = 129;
numbers[3] = 34;


Console.WriteLine("***************************");
Console.WriteLine("1. DÖNGÜ");

foreach (var item in numbers)
{
    Console.WriteLine("Numbers Dizisi : " + item);

}

Console.WriteLine("**********************");

Console.WriteLine("2.DÖNGÜ");

foreach (var item in numbers2)
{

    Console.WriteLine("Numbers2 Dizisi :" + item);
}

string firstName, lastName;

byte age;

Console.WriteLine("İsminiz : ");

firstName = Console.ReadLine();

Console.WriteLine("Soyisminiz : ");

lastName = Console.ReadLine();

Console.WriteLine("Yaşınız : ");

age = Convert.ToByte(Console.ReadLine());

Console.WriteLine($"BİLGİLERİNİZ\t:\n*******************\nİsim\t: {firstName}\nSoyisim\t: {lastName}\nYaş\t: {age}");
Console.WriteLine($"BİLGİLERİNİZ\t:\n*******************\nİsim\t: {firstName}\nSoyisim\t: {lastName}\nYaş\t: {age}");


Console.WriteLine($"BİLGİLERİNİZ : \t \n ******************* \n İsim \t: {firstName} \n Soyisim \t: {lastName} \n Yaş \t: {age}");

 // "\t" BU İFADE Escape sequence ( kaçış dizisi )  klavyedeki Tab tuşuyla aynı görevi görür.
 // Metnin içinde bir miktar boşluk bırakarak verileri hizalamana yardımcı olu
 