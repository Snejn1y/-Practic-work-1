using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._5__практична
{
    internal class SortByStage : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Stage > y.Stage)
            {
                return 1;
            }
            else if (x.Stage < y.Stage)
            {
                return -1;
            }
            else return 0;
        }
    }
}
