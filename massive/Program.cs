using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[100];
            Random rand = new Random(DateTime.Now.Millisecond);


            for (var x = 0; x < M.Length; x++)
            {
                M[x] = rand.Next(-1000, 1001);
            }
            for (var x = 0; x < M.Length; x++)
            {
                if (M[x] % 2 == 0)
              
                {
                    Console.Write(M[x] + ", ");
                   
                }
                
            }
            Console.WriteLine();
            for (var x = 0; x < M.Length; x++)
            {
                M[x] = rand.Next(-1000, 1001);
            }
            Console.WriteLine();
            for (var x = 0; x < M.Length; x++)
            {
                if (M[x] % 3 == 0)
                {
                    Console.Write(M[x] + ", ");
                }

            }
            int sum = 0;
            for (var x = 0; x < M.Length; x++)
            {
                if (M[x] < 0) sum = sum + M[x];
                    
            }
            Console.Write(M[x] + ", ");
        }
    }
}
