using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class MultiBuilding: Building
    {
        int numberOfStoreys;
        public MultiBuilding(string adress, double length, double width, double hight, int numberOfStoreys)
            :base(adress, length, width, hight)
        {
            this.numberOfStoreys = numberOfStoreys;
        }

        internal string Print()
        {
            string result = base.Print();
            result += $"\nКоличество этажей: {numberOfStoreys} шт.";
            return result;
        }





           
    }
}
