using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Mang
    {
        Tegelane[] inimesed;
        public Mang(Tegelane[] inimesed)
        {
            this.inimesed = inimesed;
        }
        public List<Tegelane> SuurimaEsemeteArvuga()
        {
            List<Tegelane> vouitjad = new List<Tegelane>();
            Tegelane comparable = inimesed[0];
            foreach (Tegelane plr in inimesed)
            {
                int arve = comparable.CompareTo(plr);
                if (arve < 0)
                {
                    comparable = plr;
                    vouitjad.Clear();
                }
                if (arve == 0) vouitjad.Add(plr);
            }
            vouitjad.Add(comparable);
            return vouitjad;
        }
        public Tegelane SuurimaPunktideArvuga()
        {
            int highest = 0;
            Tegelane vouitja = inimesed[0];
            foreach (Tegelane plr in inimesed)
            {
                int arv = plr.punktideArv();
                if (arv > highest) { highest = arv; vouitja = plr; }
            }
            return vouitja;
        }

    }
}
