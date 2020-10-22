﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Banken
{
    class Program
    {
        static List<Kund> custumerList = new List<Kund>(); // gör en lista för kunderna

        static string filePath = @"C:\test\";
        static string fileName = "custumerData";

        static void Main(string[] args)
        {
            ReadCustumerFile(); // anropar metoden för att läsa upp gammla kunder

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

                        CleanConsole();

                        break;

                    case 2: // tar bort en kund från listan
                        ShowAllCustumers();

                        int cId = GetCustumerId();

                        custumerList.RemoveAt(cId);

                        CleanConsole();

                        break;

                    case 3: // visar alla kunder
                        ShowAllCustumers();

                        CleanConsole();

                        break;

                    case 4: // visar kunders balence
                        ShowAllCustumers();

                        cId = GetCustumerId();

                        Console.WriteLine(custumerList[cId].ShowSpecificCustumerInfo());

                        CleanConsole();

                        break;

                    case 5: // lägger in en summa för en kund
                        ShowAllCustumers();

                        cId = GetCustumerId();

                        Console.WriteLine("Skriv in den summa du vill sätta in: ");
                        string strBalAdd = Console.ReadLine();
                        int intBalAdd = int.Parse(strBalAdd);

                        custumerList[cId].TransacAdd(intBalAdd);

                        CleanConsole();

                        break;

                    case 6: // tar ut en summa för en kund
                        ShowAllCustumers();

                        cId = GetCustumerId();

                        Console.WriteLine("Skriv in den summa du vill ta ut: ");
                        string strBalRemove = Console.ReadLine();
                        int intBalRemove = int.Parse(strBalRemove);

                        custumerList[cId].TransacRemove(intBalRemove);

                        CleanConsole();

                        break;
                };
                choise = SelectMenuItem(); // går tillbaka till menyn
            }
            Console.ReadKey();

            WriteCustumerToFile(); // anropar metoden för att spara kunderna

        }

        private static void CleanConsole() // ränsar konsolen
        {
            Console.WriteLine("Tryck på enter för att fortätta...");
            Console.ReadLine();

            Console.Clear();
        }


        private static int GetCustumerId() // skaffar list indexet
        {
            Console.WriteLine("Skriv kund id:");
            string custumerId = Console.ReadLine();
            int cId = int.Parse(custumerId);

            while(!(cId >= 0 && cId < custumerList.Count)) // medans cId inte >= 0 & cId inte <= antalet kunder så loopar det
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

            string strAwnser = "";
            int iAwnser=0;
            while (!(iAwnser >= 1 && iAwnser <= 7))
            {   
                if (strAwnser != "")
                {
                    Console.WriteLine("Du skerv fel, skriv rätt.");
                }

                strAwnser = Console.ReadLine();
                try
                {
                    iAwnser = int.Parse(strAwnser);
                } catch
                {
                    Console.WriteLine("Det var inte ett tal.");
                }
            }

            return iAwnser;
        }

        private static void WriteCustumerToFile() //skriver alla kunderna till en permanent text fil
        {
            string users = "";

            foreach(Kund u in custumerList)
            {
                users += u.Name + "|"; // lägger till en | för att åtskillja kundnamnen
            }
            users = users.Substring(0, users.Length - 1); // tar bort den sista | effter det sista namnet

            if(File.Exists(filePath + fileName))
            {
                File.Delete(filePath + fileName);
            }

            if(Directory.Exists(filePath) == false)
            {
                Directory.CreateDirectory(filePath);
            }

            File.WriteAllText(filePath + fileName, users);
        }

        private static void ReadCustumerFile() // läser upp kunderna från text filen
        {
            if(File.Exists(filePath + fileName))
            {
                string text = File.ReadAllText(filePath + fileName);

                String[] items = text.Split('|'); // splittar upp filen och lägger det i en arrey

                foreach(String item in items) // för varje item i arreyen String så loopar den
                {
                    Kund kund = new Kund();
                    kund.Name = item;
                    custumerList.Add(kund);
                }
            }
        }
    }
}