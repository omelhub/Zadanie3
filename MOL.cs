using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class MOL
    {
        public string FIO { set; get; }
        public string Position { set; get; }
        public List<Building> Buildings = new List<Building>();

        public Building expens()
        {
            Buildings.Sort();
            return Buildings.Last();
        }
        public void overdue()
        {
            foreach (Building a in Buildings)
            {
                if (a.Date < DateTime.Today)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Амортизация просрочена для строения №{a.Number}");
                    Console.ResetColor();
                }
            }
        }
    }
}
