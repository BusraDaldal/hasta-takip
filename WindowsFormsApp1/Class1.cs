using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hasta
    {
        public string Adi;
        public int Ucret;
        public int DogumYili;
        public string Cinsiyet;

        public int yas;
        public int IndirimliUcret;


        public void YasHesapla()
        {
            yas = DateTime.Now.Year - DogumYili;
        }

        public void IndirimliUcretHesapla()
        {
            if (yas > 65)
            {
                IndirimliUcret = 0;

            }
            else if (Cinsiyet == " Kadın")
            {
                IndirimliUcret = Ucret * 80 / 100;
            }
            else if (yas < 15)
            {
                IndirimliUcret = Ucret * 50 / 100;
            }
        }
    }
}

