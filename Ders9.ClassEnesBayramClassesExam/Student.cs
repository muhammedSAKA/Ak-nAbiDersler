using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9.ClassEnesBayramClassesExam
{
    public class Student
    {
        private string _ogrenciIsim;
        private int OgrenciNo { get; set; }
        public string OgrenciIsim { 
            get
            {
                return _ogrenciIsim;
            }
            
            
            
            set 
            { 
                
                _ogrenciIsim = value;
            
            
            }
        
        
        
        }
        private string OgrenciSoyIsim { get; set; }
        private int vize1 { get; set; }
        private int vize2 { get; set; }
        private int final { get; set; }

        private string okulIsmi { get; set; }


        public Student(int _ogrenciNo , string _ogrenciIsim , string _ogrenciSoyIsim , int _vize1 , int _vize2 , int _final , string _okulIsmi)

        {
            OgrenciNo = _ogrenciNo;
            OgrenciIsim = _ogrenciIsim;
            OgrenciSoyIsim = _ogrenciSoyIsim;
            vize1 = _vize1 ;
            vize2 = _vize2 ;
            final = _final ;
            okulIsmi = _okulIsmi ;

        }


        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("ÖĞRENCİNİN NUMARASI : " +OgrenciNo);
            Console.WriteLine("ÖĞRENCİNİN İSMİ : " +OgrenciIsim);
            Console.WriteLine("ÖĞRENCİNİN SOYİSİMİ : " +OgrenciSoyIsim);
            Console.WriteLine("ÖĞRENCİNİN BİRİNCİ VİZESİ : " +vize1);
            Console.WriteLine("ÖĞRENCİNİN İKİNCİ VİZESİ : " +vize2);
            Console.WriteLine("ÖĞRENCİNİN FİNALİ : " +final);
            Console.WriteLine("ÖĞRENCİNİN OKULUNUN İSMİ : " +okulIsmi);

        }

        public void ogrenciOrtalamasiBul()
        {

            double ortalama = (double)(vize1 + vize2) * 0.40 + (final * 0.60);

            Console.WriteLine($"{OgrenciIsim} ADLI ÖĞRENCİNİN ORTALAMASI : {ortalama}");

            if (ortalama >= 50)
            {
                Console.WriteLine("ORTALAMASI GEÇTİ!");
            }
            else
            {
                Console.WriteLine("ORTALAMASI KALDI!");
            }
                

        }

        public void OkulGetir()
        {
            Console.WriteLine($"{OgrenciIsim} {OgrenciSoyIsim} ADLI ÖĞRENCİNİN OKUL ADI {okulIsmi}");
        }


    }
}
