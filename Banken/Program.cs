using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise = SelectMenuItem();
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
