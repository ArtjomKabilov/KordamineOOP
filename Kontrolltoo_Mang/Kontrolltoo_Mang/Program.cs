using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //Эта функция даёт случайное имя
            string PaneNimi()
            {
                string[] names = { "Artem", "Igor", "Bobr", "Jojo", "Nikitka" };
                return names[rnd.Next(names.Length)];
            }
            
            Tegelane teg = new Tegelane($"{PaneNimi()}");

            teg.väljastaEsemed();
            Console.ReadLine();
        }
    }
}
