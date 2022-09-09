using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Tegelane : Uksus, IComparable<Tegelane>
    {
         string nimi;
         List<Ese> nimekiri = new List<Ese>();
        public Tegelane(string nimi/*, Ese asdf*/ )
        {
           /* nimekiri = new List<Ese>();
            nimekiri.Add( asdf);*/
            this.nimi = nimi;
        }
        public int lisaEse(int arv)
        {
            return arv;
        }
        public string info()
        {

            return $"{this.nimi} info:\n" +
               $"Esemete arv: {nimekiri.Count}\n" +
               $"Punktide arv: {punktideArv()}\n";


        }

        /*public double punktideArv(int arv)
        {
            double summa = Convert.ToDouble(arv);
            return summa;
        
        }*/
        public void väljastaEsemed()
        {
            foreach (Ese item in nimekiri)
            {
                Console.WriteLine(item.info() + " " + item.punktideArv());
            }
        }

        public void Equip(Ese item) 
        { 
            nimekiri.Add(item);
        }

        public int ItemCount() 
        { 
            return nimekiri.Count;
        }
        public int CompareTo(Tegelane other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.nimekiri.Count - other.ItemCount();
        }

        public int punktideArv()
        {
            int summa = 0;
            foreach (Ese item in nimekiri) 
            {
                summa += item.punktideArv();
            }
            return summa;
        }
    }
}
