using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MFC = new Building();
            MFC.Number = 1;
            MFC.Address = "ул. Мира, д. 1";
            MFC.Date = new DateTime(2022,2,1);
            MFC.Price = 100_000_000;

            MOL first = new MOL();
            first.FIO = "Иванов Иван Иванович";
            first.Position = "CEO";
            first.Buildings.Add(MFC);

            Console.WriteLine(first.expens().Number);
            first.overdue();
            Console.WriteLine();
        }
    }
}
