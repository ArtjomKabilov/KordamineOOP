using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus1
{
    abstract class Isik
    {
        public string nimi;
        public enum sugu { isane, emane };
        public sugu Sugu;
        public int synniAasta;
        public string kool;
        public string klass;
        public string too;
        public Isik() { }

        public Isik(string nimi, string kool, string klass, string too, sugu Sugu, int synniAasta = 0)
        {
            this.nimi = nimi;
            this.Sugu = Sugu;
            this.synniAasta = synniAasta;
            this.kool = kool;
            this.klass = klass;
            this.too = too;
        }
        public Isik(Isik ob)
        {
            this.nimi = ob.nimi;
            this.Sugu = ob.Sugu;
            this.synniAasta = ob.synniAasta;
            this.kool = ob.kool;
            this.klass = ob.klass;
            this.too = ob.too;
        }
        public virtual void prontInfo()
        {
            Console.WriteLine("{0,-10} {1} {2,4}", nimi, Sugu, synniAasta);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }
        string name;
        
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);
        public abstract void print_Info();

        public abstract void print_Haal();
    }
}
