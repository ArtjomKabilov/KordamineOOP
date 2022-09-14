using System;
using System.Collections.Generic;
using System.IO;

namespace Kontrolltoo_Mang
{
    internal class Tegelane : Uksus, IComparable<Tegelane>
    {
        string nimi;
        List<Ese> nimekiri = new List<Ese>();
        public Tegelane(string nimi)
        {

            this.nimi = nimi;
        }
        public int lisaEse(int arv)
        {
            return arv;
        }
        //Эта функция прочитывает файл eseled.txt и выводит из него информацию
        public string info()
        {

            StreamReader sr = new StreamReader(@"../../eseled.txt");
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                string[] rida = text.Split(';');
                nimekiri.Add(new Ese(rida[0], Convert.ToInt32(rida[1])));

            }
            foreach (var item in nimekiri)
            {

                Console.WriteLine($"{nimi}: " + item.nimetus + " " + item.arv);

            }

            return text;


        }
        //Эта функция выводит информацию об имени, предмети, очков за предмет и сумму очков
        public void väljastaEsemed()
        {
            Console.WriteLine(info() + " " + punktideArv());
        }

        //возвращает число из списка nimekiri
        public int UksusteArv()
        {
            return nimekiri.Count;
        }
        public int CompareTo(Tegelane other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.nimekiri.Count - other.UksusteArv();
        }
        //Эта функция подсчитывает количество очков
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
