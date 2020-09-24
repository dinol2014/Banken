﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
    {
        static List<Kund> custumerList = new List<Kund>(); // gör en lista för kunderna

        static void Main(string[] args)
        {
            int choise = SelectMenuItem(); // går till metoden för menyn

            while (choise != 7) 
            {
                switch (choise) // väljer olika alternativ beroande på svar
                {
                    case 1: // lägger till en ny kund i listan
                        Kund kund = new Kund();
                        Console.Write("Ange ditt namn: ");
                        kund.Name = Console.ReadLine();

                        custumerList.Add(kund);

                        break;

                    case 2: // tar bort en kund frön listan
                        ShowAllCustumers();

                        int cId = GetCustumerId();

                        custumerList.RemoveAt(cId);
                        break;

                    case 3: // visar alla kunder
                        ShowAllCustumers();
                        break;

                    case 4: // visar kunders balence
                        ShowAllCustumers();

                        cId = GetCustumerId();

                        Console.WriteLine(custumerList[cId].ShowSpecificCustumerInfo());
                        break;

                    case 5: // lägger in en summa för en kund
                        ShowAllCustumers();

                        cId = GetCustumerId();

                        Console.WriteLine("Skriv in den summa du vill sätta in: ");
                        string strBalAdd = Console.ReadLine();
                        int intBalAdd = int.Parse(strBalAdd);

                        custumerList[cId].Balence += intBalAdd;
                        break;

                    case 6: // tar ut en summa för en kund
                        ShowAllCustumers();

                        cId = GetCustumerId();

                        Console.WriteLine("Skriv in den summa du vill ta ut: ");
                        string strBalRemove = Console.ReadLine();
                        int intBalRemove = int.Parse(strBalRemove);

                        custumerList[cId].Balence -= intBalRemove;
                        break;
                };
                choise = SelectMenuItem(); // går tillbaka till menyn
            }
            Console.ReadKey();
        }

        private static int GetCustumerId() // skaffar list indexet
        {
            Console.WriteLine("Skriv kund id:");
            string custumerId = Console.ReadLine();
            int cId = int.Parse(custumerId);

            while(!(cId >= 0 && cId < custumerList.Count))
            {
                Console.WriteLine("Skriv kund id:");
                custumerId = Console.ReadLine();
                cId = int.Parse(custumerId);
            }
            return cId;
        }

        private static void ShowAllCustumers() // visar upp alla kunder och deras index i listan
        {
            for (int i = 0; i < custumerList.Count; i++)
            {
                Console.WriteLine("Kund id " + i + " " + custumerList[i].ShowCustumerInfo());
            }
        }

        private static int SelectMenuItem() // visar upp menyn
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
