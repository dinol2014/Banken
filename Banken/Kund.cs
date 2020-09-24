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
        public int Balence;
        public string ShowCustumerInfo()
        {
            return "User name: " + Name + Environment.NewLine;
        }

        public string ShowSpecificCustumerInfo()
        {
            return "User name: " + Name + Environment.NewLine + "Balence: " + Balence + Environment.NewLine;
        }
    }
}
