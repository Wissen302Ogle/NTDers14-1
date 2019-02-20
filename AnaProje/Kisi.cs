using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProje
{
    public class Kisi
    {
        private string AdSoyad;
        internal int Yas { get; set; }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected internal int KrediKartNo {get;set;}
        protected int TCKimlik { get; set; }

        public string FullName()
        {
            AdSoyad = this.Ad + this.Soyad;
            return AdSoyad;
        }
    }
}
