using Ders9.ClassEnesBayramClassesExam;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

List <Student> Ogrenciler = new List <Student> ();
bool kontrol = true;

Console.WriteLine("ÖĞRENCİ UYGULAMASINA HOŞ GELDİNİZ!");

while (kontrol)
{
    Console.WriteLine("1 - ÖĞRENCİ KAYDET :\n2 - ÖĞRENCİ BİLGİLERİNİ GÖSTER\n3 - ÖĞRENCİ ORTALAMASINI GÖSTER :\n4 - ÖĞRENCİ OKULUNU ÖĞREN :\n5 - ÇIKIŞ YAP");

    int kullanıcıSecim = Convert.ToInt32(Console.ReadLine());

    if (kullanıcıSecim == 1)
    {
        Console.Write("ÖĞRENCİNİN NUMARASINI GİRİNİZ :");

        int gelenNumara = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ÖĞRENCİNİN İSMİNİ GİRİNİZ :");

        string gelenIsim = Console.ReadLine()!.ToUpper();

        Console.WriteLine("ÖĞRENCİNİN SOYİSİMİNİ GİRİNİZ :");

        string gelenSoyIsim = Console.ReadLine()!.ToUpper();

        Console.WriteLine("ÖĞRENCİNİN 1. VİZESİNİ GİRİNİZ :");

        int gelenVize1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ÖĞRENCİNİN 2. VİZESİNİ GİRİNİZ :");

        int gelenVize2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ÖĞRENCİNİ FİNALİNİ GİRİNİZ :");

        int gelenFinal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ÖĞRENCİNİN OKUL ADINI GİRİNİZ :");

        string gelenOkul = Console.ReadLine()!;

        Ogrenciler.Add(new Student(gelenNumara,gelenIsim,gelenSoyIsim,gelenVize1,gelenVize2,gelenFinal,gelenOkul));

        Console.WriteLine("ÖĞRENCİ BAŞARIYLA KAYDEDİLDİ !");


    }

    else if (kullanıcıSecim == 2)
    {
        if (Ogrenciler.Count == 0)
        {
            Console.WriteLine("LİSTE'DE HENÜZ ÖĞRENCİ YOK");
        }

        else
        {


            foreach (var student in Ogrenciler)
            {

                student.ogrenciBilgileriGoster();

            }
        }


    }

    else if (kullanıcıSecim == 3)
    {
        if (Ogrenciler.Count == 0)
        {
            Console.WriteLine("LİSTE'DE HENÜZ ÖĞRENCİ YOK");

        }

        else
        {


            Console.WriteLine("Ortalamasını Görmek İstediğiniz Öğrenciyi Giriniz :");
            string aranacakIsim = Console.ReadLine()!;

            bool bulundu = false; // 1. Bayrağı indiriyoruz (Henüz bulamadık)

            foreach (Student student in Ogrenciler)
            {
                if (student.OgrenciIsim == aranacakIsim)
                {
                    student.ogrenciOrtalamasiBul();
                    bulundu = true; // 2. Bulunca bayrağı kaldırıyoruz
                    break; // Bulduysak aramayı bitir, boşuna diğerlerine bakma
                }
            }

            // 3. Döngü bitti! Eğer hala bulunamadıysa (false ise) hatayı BURADA ver.
            if (!bulundu)
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR İSİM GİRİNİZ! (Öğrenci bulunamadı)");
            }
        }
    }

    else if (kullanıcıSecim == 4)


    {
        if (Ogrenciler.Count <= 0)
        {
            Console.WriteLine("LİSTE'DE HENÜZ ÖĞRENCİ YOK");
        }

        else
        {
            Console.WriteLine("OKULUNU ÖĞRENMEK İSTEDİĞİNİZ ÖĞRENCİYİ GİRİNİZ");
            string arananOkul = Console.ReadLine()!;

            bool okulBulundu = false;

            foreach (Student okularama in Ogrenciler)
            {
                if (okularama.OgrenciIsim == arananOkul)
                {
                    okularama.OkulGetir();
                    okulBulundu = true;
                    break;
                }
               

            }
            if (!okulBulundu)
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR ÖĞRENCİ İSMİ GİRİNİZ!");
            }
        }


    }
    else if (kullanıcıSecim == 5)
    {

        Console.WriteLine("ÇIKIŞ YAPILIYOR İYİ GÜNLER DİLEİZ");

        kontrol = false;
        break;
    }
    else
    {
        Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!");
       
    }






}