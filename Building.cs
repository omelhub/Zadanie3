using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Building : IComparable
    {
        public int Number { set; get; }
        public string Address { set; get; }
        public DateTime Date { set; get; }
        public int Price { set; get; }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(obj);
        }
    }
}
