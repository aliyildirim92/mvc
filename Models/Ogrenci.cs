using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ogrenciKayitMvc.Models
{
    public class Ogrenci
    {
        int Notu;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ders { get; set; }
        public int Not
        {
            get { return Notu; }
            set
            {
                if (value > 50)
                {
                    Notu = value;
                }
            }
        }
    }
}