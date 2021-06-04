using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    class musical_instrument
    {
        internal string name;
        internal int price;
        internal bool availability;
        internal string articleNumber;
        internal string type;
        internal string subtype;
        internal int discount;

        public musical_instrument(string n, int p, bool av, string ar, string t, string s, int d)
        {
            name = n;
            price = p;
            availability = av;
            articleNumber = ar;
            type = t;
            subtype = s;
            discount = d;
        }

        public override string ToString()
        {
            return name + " " + price + " " + availability + " " + articleNumber + " " + type + " " + subtype + " " + discount;
        }
    }
}
