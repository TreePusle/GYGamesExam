using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static int FindMaxDifferent(string s)
        {
           List<char> different = new List<char>();
            char[] sChar = s.ToArray();
            int max = 0,t=0;
            for (int i=0; i < s.Length; i++)
            {
                if (!different.Contains(sChar[i]))
                {
                    different.Add(sChar[i]);
                    t++;
                }
                else
                {
                    if (t > max)
                        max = t;
                    t = 0;
                    different.Clear();
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMaxDifferent("skfangauhdiaisda"));
            Console.ReadLine();
        }
    }
}
