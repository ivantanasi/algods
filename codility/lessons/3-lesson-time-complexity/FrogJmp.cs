using System;

namespace algods
{
    class FrogJmp
    {
        public void FrogJmpMethod()
        {
            // int X = 10;
            // int Y = 85;
            // int D = 30;

            int X = 5;
            int Y = 1000000000;
            int D = 2;

            int jumps = 0;

            // first solution
            // while (X < Y)
            // {
            //     X += D;
            //     jumps++;
            // }

            // second solution
            int distance = (Y - X);
            jumps = Convert.ToInt32(distance / D);
            int remainder = distance % D;

            if (remainder > 0)
            {
                jumps++;
            }


            Console.WriteLine("FrogJmp {0}", jumps);
        }
    }
}