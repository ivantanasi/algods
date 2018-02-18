using System;

namespace algods
{
    class BinarySearch
    {
        public void BinarySearchMethod()
        {

            int[] array = { 10, 14, 19, 26, 27, 31, 33, 35, 42, 44 };
            Array.Sort(array);

            int start = 0;
            int end = array.Length;
            int mid = (start + end) / 2;
            int searchNum = 33;

            Console.WriteLine("BinarySearch {0}");
        }
    }
}