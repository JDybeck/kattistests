using System;
using System.Collections.Generic;
using System.Linq;

namespace KattistestB
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            List<int> av = new List<int>();
            for (int i = 0; i < T; i++)
            {
                int an = Convert.ToInt32(Console.ReadLine());
                List<double> pp = new List<double>();

                for (int ia = 0; ia < an; ia++)
                {
                    int v = Convert.ToInt32(Console.ReadLine());
                    av.Add(v);
                }
                int k = av.AsQueryable().Sum();
                foreach (var x in av)
                {
                    double dp = (double)x / k;
                    double p = (double)dp * 100;
                    pp.Add(p);
                }
                double m = pp.Max();
                int d = pp.IndexOf(m);
                d ++;
                int u = 0;
                foreach(var x in pp)
                {
                    if(x == m)
                    {
                        u++;
                    }
                }
                int tm = 2;
                if (tm <= u)
                {
                    Console.WriteLine("no winner");
                    pp.Clear();
                    av.Clear();
                    
                }
                else if (m <= 50 && pp != null)
                {
                    Console.WriteLine("minority winner " + d);
                }
                if (m > 50 && pp != null)
                {
                    Console.WriteLine("majority winner " + d);
                }

                pp.Clear();
                av.Clear();
            }
        }
    }
}