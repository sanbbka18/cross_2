using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib3
{
    ///calculation of mathematical functions
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="ε">to find the sum of n members of a series</param>
        /// <returns>starts the cycle of finding the amount</returns>
        public static double sum(int ε)
        {
            int x = 4;
            double Sum = 1;
            for (int i = 1; i <= ε; i++)
            {
                Sum = Sum + (Math.Pow(x, i)) / i;
            }
            return Sum;
        }
    }
}
