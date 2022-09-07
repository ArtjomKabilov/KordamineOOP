using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    internal class Kass: koduloom
    {
        public enum toug1 { Parisa_kass, Meini_kass, Bengali_kass, sfinks, Ragdoll };
        public toug1 toug2 { get; set; }
        //public string toug;//Tõung - порода
        public Kass(toug1 toug2, string nimi, string varv, sugu loomaSugu, sugu1 stealth, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, stealth, kaal, vanus, elav)
        {
            this.toug2 = toug2;
        }
        public Kass(Kass kass)//Kloonimiseks
        {
            this.nimi = kass.nimi;
            this.varv = kass.varv;
            this.loomaSugu = kass.loomaSugu;
            this.stealth = kass.stealth;
            this.kaal = kass.kaal;
            this.vanus = kass.vanus;
            this.elav = kass.elav;
            this.toug2 = kass.toug2;


        }
        public Kass(string nimi, string varv, sugu loomaSugu)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
        }
        public override void print_Haal()
        {
            Console.WriteLine("mjau, MJAAAAAAAUU");
        }

        public override void print_Info()
        {
            Console.WriteLine($"{toug2}, {varv}, {nimi} ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana, tema salapära {stealth} ");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaLoomaSugu(sugu uusLoomaSugu) { loomaSugu = uusLoomaSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
        public void muudaElav(bool uusElav) { elav = uusElav; }
        public void muudaToug1(toug1 uusToug1) { toug2 = uusToug1; }
        public void muudaStealth(sugu1 uusSugu1) { stealth = uusSugu1; }
    }
}
