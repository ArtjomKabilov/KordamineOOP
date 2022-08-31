using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    internal class Koer : koduloom
    {
        public enum toug { Mops, Buldog, Pudel, Haski, Jorkširi_terjer };
        public toug toug1;
        //public string toug;//Tõung - порода
        public Koer(toug toug1, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.toug1 = toug1;
        }
        public Koer(Koer koer)//Kloonimiseks
        {
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.elav = koer.elav;
            this.toug1 = koer.toug1;
            
        }
        public override void print_Haal()
        {
            Console.WriteLine("Au, Auuuuuu");
        }

        public override void print_Info()
        {
            Console.WriteLine($"{toug1}, {varv}, {nimi} ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaLoomaSugu(sugu uusLoomaSugu) { loomaSugu = uusLoomaSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
        public void muudaElav(bool uusElav) { elav = uusElav; }
        public void muudaToug1(toug uusToug1) { toug1 = uusToug1; }


    }
}
