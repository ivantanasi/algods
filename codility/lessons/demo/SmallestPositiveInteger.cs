using System;

namespace codility
{
    class SmallestPositiveInteger
    {
        public int SmallestPositiveIntegerMethod()
        {
            // int[] intArray = { 1, 3, 6, 4, 1, 2 };
            // int[] intArray = { -3, -1, -10 };
            int[] intArray = { -3, -1, -10, 1, 3, 6, 4, 1, 2 };
            // int[] intArray = { -3, -1, -10, 3, 6, 4, 2 };
            // int[] intArray = { 1, 2, 3 };

            Array.Sort(intArray);
            int smallestPositiveInteger = 1;

            if (smallestPositiveInteger > intArray[intArray.Length - 1])
            {
                // if array elements are all negative integers or zero
                return smallestPositiveInteger;
            }
            else
            {
                int counter = 0;
                bool firstPositiveInteger = true;
                foreach (int a in intArray)
                {
                    if (a <= 0)
                    {
                        counter++;
                    }
                    else
                    {
                        if (smallestPositiveInteger < a && firstPositiveInteger)
                        {
                            return smallestPositiveInteger;
                        }
                        else
                        {
                            if (counter == intArray.Length - 1)
                            {
                                return a + 1;
                            }
                            else if (intArray[counter + 1] - intArray[counter] > 1)
                            {
                                return intArray[counter] + 1;
                            }
                            counter++;
                            firstPositiveInteger = false;
                        }

                    }

                }
            }
            return smallestPositiveInteger;
        }
    }
}