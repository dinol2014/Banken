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
        public List<int> transactions = new List<int>(); // gör en lista för transaktioner

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

            foreach (int t in transactions)
            {
                total += t;
            }

            return total;
        }

        private string ShowTransacList() // visar en lista med transaktioner
        {
            string tranactionList = "";

            foreach(int t in transactions)
            {
                transactions[t];
            }

            return
        }

        public void TransacAdd(int intBalAdd) // lägger till en insättning i transaktions listan 
        {
            transactions.Add(intBalAdd);
        }

        public void TransacRemove(int intBalRemove) // lägger till en utsättning i transaktions listan
        {
            transactions.Add(intBalRemove * -1);
        }
    }
}