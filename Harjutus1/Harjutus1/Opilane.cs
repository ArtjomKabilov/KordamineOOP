using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Harjutus1.Isik;

namespace Harjutus1
{
    internal class Opilane: Isik
    {

        public Opilane(string nimi, sugu Sugu, int synniAasta, string kool, string klass, string too) : base(nimi, kool, klass, too, Sugu, synniAasta) { }
        
        public Opilane(Opilane opilane)//Kloonimiseks
        {
            this.nimi = opilane.nimi;
           
            this.Sugu = opilane.Sugu;
            
            this.synniAasta = opilane.synniAasta;
            this.kool = opilane.kool;
            this.klass = opilane.klass;
            this.too = opilane.too;


        }

        public override void print_Info()
        {
            Console.WriteLine($"See on {nimi} ta on {Sugu} ja ta on sündinud {synniAasta} aasta, ja ta on {arvutaVanus()}. Ta õpib {kool},{klass},{too}");
        }
        //public void MuudaNimi(string uusNimi) { nimi = uusNimi; }     
        public void muudaLoomaSugu(sugu uusSugu) { Sugu = uusSugu; }
        public void muudaVanus(int uusSynniAasta) { synniAasta = uusSynniAasta; }

        /*public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double sedaTeEiNae = (tootasu - maksuvaba) * (tulumaks / 100);
            double netopalk = tootasu - sedaTeEiNae;
            return netopalk;
        }*/
        public void muudaNimi(string name)
        {
            this.nimi = name;
            Console.WriteLine("kirjuta nimi" + name);
        }
        public override void print_Haal()
        {
            throw new NotImplementedException();
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }

    }
}
