using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_Addition
{
    class YearCalculator
    {
        internal static int addUpNumbers(string year)
        {
            int total = 0;
            for (int i = 0; i < year.Length; i++)
            {
                total += int.Parse(year[i].ToString());
            }
            return total;
        }
    }
}
