using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Kund
    {
        public string Name;
        public List<Transaction> transactions = new List<Transaction>(); // gör en lista för transaktioner

        public string ShowCustumerInfo() // visar information om kunden
        {
            return "User name: " + Name + Environment.NewLine;
        }

        public string ShowSpecificCustumerInfo() // visar balence för kunden
        {
            return "User name: " + Name + Environment.NewLine + "Balence: " + Balence() + Environment.NewLine + ShowTransacList();
        }

        private int Balence() // räknar ut kundens balence genom att lägga ihop alla värden i transaktions listan
        {
            int total = 0;

            foreach (Transaction t in transactions)
            {
                total += t.ammount;
            }

            return total;
        }

        private string ShowTransacList() // visar en lista med transaktioner
        {
            string tranactionList = "";

            foreach(Transaction t in transactions)
            {
                tranactionList += "Datum:" + t.dateTime + " Mängd: " + t.ammount + Environment.NewLine;
            }

            return tranactionList;
        }

        public void TransacAdd(int intBalAdd) // lägger till en insättning i transaktions listan 
        {
            Transaction t = new Transaction();
            t.ammount = intBalAdd;
            t.dateTime = DateTime.Now;

            transactions.Add(t);
        }

        public void TransacRemove(int intBalRemove) // lägger till en utsättning i transaktions listan
        {
            Transaction t = new Transaction();
            t.ammount = intBalRemove * -1;
            t.dateTime = DateTime.Now;

            transactions.Add(t);
        }
    }
}