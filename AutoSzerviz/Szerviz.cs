using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSzerviz
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek;

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervizbe");
        }

        public void InformaciokListazasa()
        {
            foreach (var j in jarmuvek)
            {
                if (j.GetType() == typeof(ElektromosAuto))
                {
                    j.InformaciotAd();

                } else if (j.GetType() == typeof(TeherAuto))
                {
                    j.InformaciotAd();
                } 
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach(var j in jarmuvek)
            {
                if (j.SzervizSzukseges1)
                {
                    j.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {j.Rendszam1} szervizelése jelenleg nem szükséges");
                }
            }
        }
    }
}
