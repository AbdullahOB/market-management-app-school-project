﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_manager
{

   public class Calisanlar
    {

        private int hIzinSayisi = 4;
        private int yIzinSayisi = 14;
        private int kalanIzinSayisi; 
        private string adSoyad, adres, subeAdi;
        private long cepTel;
        private double maas;
        private string poz;
        
        public Calisanlar(string adSoyad, string adres,  long cepTel, string subeAdi, double maas, int hIzinSayisi, int yIzinSayisi, int kalanIzinSayisi , string poz)
        {
            this.adSoyad = adSoyad;
            this.adres = adres;
            this.subeAdi = subeAdi;
            this.cepTel = cepTel;
            this.maas = maas;
            this.hIzinSayisi = hIzinSayisi;
            this.yIzinSayisi = yIzinSayisi;
            this.kalanIzinSayisi = kalanIzinSayisi;
            this.poz = poz; 
          

        }

        
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }
        public string Adress
        {
            get { return adres; }
            set { adres = value; }
        }
        public long CepTel
        {
            get { return cepTel; }
            set { cepTel = value; }
        }
        public string SubeAdi
        {
            get { return subeAdi; }
            set { subeAdi = value; }
        }
      
        public double Maas
        {
            get { return maas; }
            set { maas = value; }
        }
        public int HizinSayisi
        {
            get { return hIzinSayisi; }
            set { hIzinSayisi = value; }
        }
        public int YizinSayisi
        {
            get { return yIzinSayisi; }
            set { yIzinSayisi = value; }
        }
        public  int KalanIzinSayisi
        {
            get { return kalanIzinSayisi;  }
            set { kalanIzinSayisi = value;  }
        }

        public string Poz
        {
           get { return poz; }
           set { poz = value; }
        }


    }
}
