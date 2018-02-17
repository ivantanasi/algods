using System;

namespace algods
{
    class LinearSearch
    {
        public void LinearSearchMethod()
        {

            int[] array = { 10, 14, 19, 26, 27, 31, 33, 35, 42, 44 };
            int searchNum = 33;

            int position = -1;
            int counter = 0;
            foreach (int num in array)
            {
                counter++;
                if (searchNum == num)
                {
                    position = counter;
                    break;
                }
            }

            Console.WriteLine("LinearSearch {0}", position);
        }
    }
}