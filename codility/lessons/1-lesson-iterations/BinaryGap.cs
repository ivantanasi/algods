using System;

namespace algods
{
    class BinaryGap
    {
        public int BinaryGapMethod()
        {
            string binary = Convert.ToString(1041, 2);

            int counter = 0;
            int longestBinaryGap = 0;
            foreach (char binChar in binary)
            {
                if (binChar == '0')
                {
                    counter++;
                }
                else
                {
                    if (longestBinaryGap < counter)
                    {
                        longestBinaryGap = counter;
                    }
                    counter = 0;
                }
            }

            return longestBinaryGap;
        }
    }
}