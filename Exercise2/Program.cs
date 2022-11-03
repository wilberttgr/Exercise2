using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Exercise
    {
        static void Main(string[] args)
        {
            int i, n, wt, temp;
            int[] arr = new int[50];

            // tent banyak data
            Console.Write("Jumlah Data : ");
            n = Convert.ToInt32(Console.ReadLine());

            //input data array
            for (i = 0; i <= n- 1; i++)
            {
                Console.Write("Data ke {0} : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
