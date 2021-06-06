using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceRollingprob
{
class Program
{
static void Main(string[] args)
{
string[] tokens = Console.ReadLine().Split();
int N = int.Parse(tokens[0]);
int M = int.Parse(tokens[1]);
var sumSides = N + M;
int[] sums = new int[sumSides+1];
int sum = 0;
int miljoner = 10000000;
if (4 <= N && N <= 20 && 4 <= M && M <= 20)
{
Random r = new Random();
for (int i = 0; i < miljoner; i++)
{
int dice1 = r.Next(1, N+1); 
int dice2 = r.Next(1, M+1);
sum = dice1 + dice2;
sums[sum] += 1;
}
double max = Convert.ToDouble(sums.Max())/ miljoner;
List<int> list = new List<int>();
for (int i = 0; i < sums.Length; i++)
{
double perc = Convert.ToDouble(sums[i]) / miljoner;
if (Math.Round(perc,3) == Math.Round(max,3))
{
list.Add(i);
}
}
foreach(var x in list) { 
Console.WriteLine(x);
}
}
}
}
}
