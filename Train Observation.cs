using System;
using System.Collections.Generic;
using System.Linq;


namespace Kattistest2021
{
    class tagobservationer

    {
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            List<int> minuter = new List<int>();
            List<int> sekunder = new List<int>();

            //if (1 <= N && 1000 <= N)
            //{

                for (int i = 0; i < N; i++)
                {
                    string[] tokens = Console.ReadLine().Split();
                    int M = int.Parse(tokens[0]);
                    int S = int.Parse(tokens[1]);

                    if (M <= 60 && S <= 3600)
                    {
                        minuter.Add(M);
                        sekunder.Add(S);
                    }

                }

            //}
            int minuterSum = minuter.AsQueryable().Sum();
            int sekunderSum = sekunder.AsQueryable().Sum();
            double sekunderTillMinuter = (double)sekunderSum / 60;
            double sekDivMin = (double)sekunderTillMinuter / minuterSum;
            

            if (sekDivMin > 1)
            {
                Console.WriteLine(sekDivMin.ToString("#.#######"));
            }
            else
            {
                Console.WriteLine("measurement error");
            }
        }
    }
}
