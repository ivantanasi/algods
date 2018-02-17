using System;
using System.Linq;

namespace algods
{
    class PermMissingElem
    {
        public void PermMissingElemMethod()
        {
            long[] A = { 2, 3, 1, 5 };

            long n = A.Length + 1;
            long sumOfN = (n * (n + 1)) / 2;
            long arraySum = A.Sum();
            long missingNumber = sumOfN - arraySum;

            Console.WriteLine("PermMissingElemMethod {0}", missingNumber);
        }
    }
}