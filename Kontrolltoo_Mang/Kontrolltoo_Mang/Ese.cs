using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    class Ese : Uksus
    {
        public string nimetus { get; set; }
        public int arv { get; set; }
        public Ese(string nimetus, int arv)
        {
            this.nimetus = nimetus;
            this.arv = arv;
        }
        public string info()
        {
            return nimetus;
        }

        public int punktideArv()
        {
            return arv;
        }

        public int CompareTo(Tegelane other)
        {
            throw new NotImplementedException();
        }
    }
}
