/*
Print the Pattern in reverse from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-13 

Write a program to output the following patterns given the number of rows: 
Pattern #1 
1 
22 
333 
4444 
55555 
and so on. 

Pattern #2 
1 
12 
123 
1234 
12345 
and so on. 

Pattern #3 
1 
13 
135 
1357 
13579 
and so on. 

Pattern #4 
0 
01 
010 
0101 
01010 
and so on. 

As a second challenge, create a program to output the patterns in reverse (from bottom row to top).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintThePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = 1; // Insert a pattern type (1, 2, 3, 4)
            var rows = 5; // Insert a number of rows

            PrintPattern(pattern, rows);
        }

        static void PrintPattern(int p, int r)
        {
            Console.WriteLine($"Pattern #{p}");

            for (int i = r; i >= 1; i--)
            {
                string s = String.Empty;

                for (int j = 1; j <= i; j++)
                {
                    s += (p == 1) ? i : ((p == 2) ? j : ((p == 3) ? j * 2 - 1 : ((p == 4) ? (j - 1) % 2 : 0)));
                }

                Console.WriteLine($"{s}");
            }
        }
    }
}
