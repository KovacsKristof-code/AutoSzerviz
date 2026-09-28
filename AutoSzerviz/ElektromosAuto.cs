using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSzerviz
{
    public class ElektromosAuto: Jarmu
    {
        private int AkkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra,int uzemanyagSzint, bool szervizSzukseges, int akkumulator): base(rendszam, kor, kilometerOra, uzemanyagSzint, szervizSzukseges)
        {
            UzemanyagSzint1 = 0;
            Akkumulator1 = akkumulator;
        }

        public int Akkumulator1 { get => AkkumulatorSzint; set {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 100)
                {
                    value = 100;
                }
            } }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{this.Rendszam1} - {this.Kor1} éves elektromos autó, {this.KilometerOra1} km-rel, {this.AkkumulatorSzint} % töltöttséggel.");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra1 = 10000;
                AkkumulatorSzint += 20;
                Console.WriteLine("A jármű szervizelése megtörtént.");
            }
        }
    }
}
