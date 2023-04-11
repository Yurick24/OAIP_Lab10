using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAIP_Lab10
{
    public class QuickSort : IStrategy
    {
        public int iterationCount = 0;
        public static Form1 form1;



        public int[] Algorithm(int[] array, int a, int b)
        {
            int i = a;
            int j = b;
            int middle = array[(a + b) / 2];
            while (i <= j)
            {
                while (array[i] < middle)
                {
                    i++;
                }
                while (array[j] > middle)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temporaryVariable = array[i];
                    array[i] = array[j];
                    array[j] = temporaryVariable;
                    i++;
                    j--;
                }
            }
            if (a < j)
            {
                Algorithm(array, a, j);
            }
            if (i < b)
            {
                Algorithm(array, i, b);
            }

            return null;
        }

    }
}
