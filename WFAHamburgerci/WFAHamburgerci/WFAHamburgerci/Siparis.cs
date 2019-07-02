using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerci
{
    //Bir siparişin .......... özelliği vardır.
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public Boyut Boyutu { get; set; }
        public List<Extra> ExtraMalzemesi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;

            ToplamTutar += SeciliMenusu.Fiyati;

            if (Boyutu == Boyut.Kucuk)
                ToplamTutar += 1;
            else if (Boyutu == Boyut.Orta)
                ToplamTutar += 2;
            else
                ToplamTutar += 4;

            foreach (Extra exMalzeme in ExtraMalzemesi)
            {
                ToplamTutar += exMalzeme.Fiyati;
            }

            ToplamTutar = ToplamTutar * Adet;
            //ToplamTutar *= Adet;
        }


        //SteakHouse Menu, x2 Adet, Buyuk Boy, Extra Malzemeler {Hardal, BBQ, Turşu} -> 22 TL
        public override string ToString()
        {
            if (ExtraMalzemesi.Count < 1)
            {
                return string.Format("{0} Menu, x{1} Adet, {2} Boy, Toplam : {3} TL", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar);
            }
            else
            {
                string exMalzemeler = null;

                foreach (Extra item in ExtraMalzemesi)
                    exMalzemeler += item.ExtraAdi + ",";
                exMalzemeler.Trim(',');

                return string.Format("{0} Menu, x{1} Adet, {2} Boy, ({3}) Toplam : {4} TL", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), exMalzemeler, ToplamTutar);
            }


        }
    }
}
