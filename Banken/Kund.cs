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
        public List<int> transactions = new List<int>();

        public string ShowCustumerInfo()
        {
            return "User name: " + Name + Environment.NewLine;
        }

        public string ShowSpecificCustumerInfo()
        {
            return "User name: " + Name + Environment.NewLine + "Balence: " + Balence() + Environment.NewLine;
        }

        public int Balence()
        {
            int total = 0;

            foreach (int t in transactions)
            {
                total += t;
            }

            return total;
        }

        public void TransacAdd(int intBalAdd)
        {
            transactions.Add(intBalAdd);
        }

        public void TransacRemove(int intBalRemove)
        {
            transactions.Add(intBalRemove * -1);
        }
    }
}