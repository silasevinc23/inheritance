﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public abstract class BaseKisi
    {
        public string _ad;
        public string _soyad;


        public virtual void Bilgiler()
        {

            Console.WriteLine("Ad :" + _ad + "Soyad :" + _soyad);
        }
 
    }

    public class Ogrenci : BaseKisi
    {
        public int _ogrenci_no;

        public override void Bilgiler()
        {
            
            Console.WriteLine("Ad :" + _ad + " Soyad :" + _soyad + " Ogrenci Numarası :" + _ogrenci_no);
        }

    }



    public class Ogretmen: BaseKisi
    {
        public double _maas_bilgisi;
        
        public override void Bilgiler()
        {
            
            
            Console.WriteLine("Ad :" + _ad + " Soyad :" + _soyad + " Maas :" + _maas_bilgisi);
        }

    }



}
