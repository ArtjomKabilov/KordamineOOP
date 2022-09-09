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
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Peaklass.PlayGame(8);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Пожалуйста заполните файл eseled.txt на рабочем столе и попробуйте снова.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Пожалуйста создайте файл eseled.txt на рабочем столе и попробуйте снова.");
            }
            Console.ReadLine();
        }
    }
}
