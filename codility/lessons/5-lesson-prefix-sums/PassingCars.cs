using System;

namespace algods
{
    class PassingCars
    {
        int ukupanBroj = 0;
        public int PassingCarsMethod()
        {
            int[] A = { 0, 1, 0, 1, 1 };

            // int countPassingCars = 0;
            int countPosition = 0;

            CountPassingCars(A, countPosition);


            if (ukupanBroj > 1000000000)
            {
                ukupanBroj = -1;
            }

            return ukupanBroj;
        }

        private int CountPassingCars(int[] cars, int countPosition)
        {

            for (int i = countPosition; i < cars.Length; i++)
            {
                if (cars[i] == 0)
                {
                    // get the numbers of 1 elements in array
                    ukupanBroj += CountCarsGoingToWest(cars, i);
                    CountPassingCars(cars, i + 1);
                    break;

                }
            }

            return 1;
        }

        private int CountCarsGoingToWest(int[] cars, int position)
        {
            int count = 0;
            for (int i = position; i < cars.Length; i++)
            {
                if (cars[i] == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}