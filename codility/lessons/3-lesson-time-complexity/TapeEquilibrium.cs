using System;
using System.Linq;

namespace algods
{
    class TapeEquilibrium
    {
        public void TapeEquilibriumMethod()
        {
            int[] A = { 3, 1, 2, 4, 3 };

            // number of possible splits
            int P = A.Length - 1;
            int minAbsoluteDifference = Math.Abs(A.Sum());

            int position;
            int firstPart;
            int secondPart;
            int absValue;

            while (P > 0)
            {
                position = 0;
                firstPart = 0;
                secondPart = 0;
                foreach (int a in A)
                {
                    if (position < P)
                    {
                        firstPart += a;
                    }
                    else
                    {
                        secondPart += a;
                    }
                    position++;
                }

                absValue = Math.Abs(firstPart - secondPart);
                if (minAbsoluteDifference > absValue)
                {
                    minAbsoluteDifference = absValue;
                }
                P--;
            }

            Console.WriteLine("Min abs value is {0}", minAbsoluteDifference);
        }
    }
}