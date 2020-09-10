using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<Kund> custumerList = new List<Kund>();

        static void Main(string[] args)
        {
            int choise = SelectMenuItem();

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Du valde 1");

                    Kund kund = new Kund();
                    Console.Write("Ange ditt namn: ");
                    kund.Name = Console.ReadLine();

                    custumerList.Add(kund);

                    break;

                case 2:
                    Console.WriteLine("Du vale 2");
                    break;

                case 3:
                    Console.WriteLine("Du valde 3");
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Inte implementerat");
                    break;


                case 7:
                    Console.WriteLine("Du valde 7");
                    break;
            };

            Console.ReadKey();
        }

        private static int SelectMenuItem()
        {
            Console.WriteLine("1 : Add a user.");
            Console.WriteLine("2 : Remove a user.");
            Console.WriteLine("3 : Show all users.");
            Console.WriteLine("4 : Show balecne for a user.");
            Console.WriteLine("5 : Make a insertion for a user.");
            Console.WriteLine("6 : Make a withdrow for a user.");
            Console.WriteLine("7 : Close program.");

            string strAwnser = Console.ReadLine();
            return int.Parse(strAwnser);
        }
    }
}
