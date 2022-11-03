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
            int tgr, n, wt, temp;
            int[] arr = new int[50];

            // tent banyak data
            Console.Write("Jumlah Data : ");
            n = Convert.ToInt32(Console.ReadLine());

            //input data array
            for (tgr = 0; tgr <= n- 1; tgr++)
            {
                Console.Write("Data ke {0} : ", tgr + 1);
                arr[tgr] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
