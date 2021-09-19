using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib2
{
    public class Class1
    {
        /// <summary>
        /// multiplication
        /// </summary>
        /// <returns>starts the cycle of finding the amount</returns>
        public static double mul(double x)
        {
            double P = 1;
            for (double j = 2; j <= 64; j++)
            {
                for (double i = 1; i <= 63; i++)
                {
                    P *= (x - (i+1)) / (x - (j+1));
                }
            }
            return P;
        }
    }
}
