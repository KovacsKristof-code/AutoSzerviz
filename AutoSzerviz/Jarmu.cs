using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSzerviz
{
    public class Jarmu
    {
        private string Rendszam;
        private int Kor;
        private int KilometerOra;
        private int UzemanyagSzint;
        private bool SzervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges)
        {
            Rendszam1 = rendszam;
            Kor1 = kor;
            KilometerOra1 = kilometerOra;
            UzemanyagSzint1 = uzemanyagSzint;
            SzervizSzukseges1 = szervizSzukseges;
        }

        public string Rendszam1 { get => Rendszam; set => Rendszam = string.IsNullOrEmpty(value) ? "ISMERETLEN" : value; }
        public int Kor1 { get => Kor; set => Kor = Math.Clamp(value, 0, 50); }
        public int KilometerOra1
        {
            get => KilometerOra; set
            {
                if(value < 0)
                {
                    value = 0;
                }
                else
                {
                    KilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint1 { get => UzemanyagSzint; set
            {
                if (value < 0)
                {
                    value = 0;
                } else if (value > 100)
                {
                    value = 100;
                }
                else
                {
                    UzemanyagSzint = Math.Clamp(value, 0, 50);
                }
            } }
        public bool SzervizSzukseges1 { get => SzervizSzukseges; set {
            if (KilometerOra > 200000)
                {
                    value = true;
                }
            else
                {
                    value = false;
                }
            } }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{this.Rendszam} - {this.Kor} éves jármű, {this.KilometerOra} km-rel.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
                UzemanyagSzint -= 10;
                Console.WriteLine("A jármű szervizelése megtörtént. ");
            }
        }

    }
}
