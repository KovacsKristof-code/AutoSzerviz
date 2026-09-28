using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSzerviz
{
    public class TeherAuto: Jarmu
    {
        private int Rakomany;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges, int rakomany): base(rendszam, kor, kilometerOra, uzemanyagSzint, szervizSzukseges)
        {
            Rakomany = rakomany;
        }

        public int Rakomany1 { get => Rakomany; set {
            if (value < 0)
                {
                    value = 0;
                }
            else if (value > 20)
                {
                    value = 20;
                }
            else
                {
                    Rakomany = Math.Clamp(value, 0, 20);
                }
            } }
        public override void InformaciotAd()
        {
            Console.WriteLine($"{this.Rendszam1} - {this.Kor1} éves teherautó, {this.KilometerOra1} km-rel, rakomány: {Rakomany} tonna");
        }

        public override void Szervizel(int dij)
        {
            base.Szervizel(dij);
        }
    }
}
