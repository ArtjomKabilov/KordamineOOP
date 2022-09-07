using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    abstract class koduloom
    {
       
        public string nimi;
        public string varv { get; set; }
        //public char sugu;
        public enum sugu { isane,emane};
        public sugu loomaSugu { get; set; }
        public double kaal { get; set; }
        public int vanus { get; set; }
        public bool elav { get; set; } //Kui true, siis elav; kui false siis on surnud
        public enum sugu1 { hight, low};
        public sugu1 stealth { get; set; }

        public koduloom() { }
        public koduloom(string nimi, string varv, sugu loomaSugu)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
        }

        public koduloom(string nimi, string varv, sugu loomaSugu, sugu1 stealth, double kaal = 0.0, int vanus = 0, bool elav = false)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
            this.stealth = stealth;
        }
        public abstract void print_Info();

        public abstract void print_Haal();

        
    }
}
