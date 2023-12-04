using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic._4_практична
{
    public class ArrayAnalyzer : IArrayAnalyzer
    {
        public int CountMaxConsecutiveZeros(int[] array)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (var value in array)
            {
                if (value == 0)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    }
}
