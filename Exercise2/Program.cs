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

            // cetak data sebelum diurutkan 
            Console.Write("\nData sebelum diurutkan\n");
            for (tgr = 0; tgr <= n - 1; tgr++)
            {
                Console.Write("{0} ", arr[tgr]);
            }

            // menu
            Console.Write("\n");
            Console.WriteLine("Pilih");
            Console.WriteLine("1. Merge Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.Write("Pilihan : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            
            switch (pilihan)
            {
                case 1:
                    for (tgr = 1; tgr < n; tgr++)
                    {
                        for (wt = 0; wt < n - tgr; wt++)
                        {
                            if (arr[wt] > arr[wt + 1]) 
                            {
                                temp = arr[wt];
                                arr[wt] = arr[wt + 1];
                                arr[wt + 1] = temp;
                            }
                        }
                    }
                    break;
                case 2:
                    //Insertion Sort
                    wt = 0;
                    for (tgr = 1; tgr <= n - 1; tgr++)
                    {
                        temp = arr[tgr];
                        wt = tgr - 1;
                        while ((wt >= 0) && (arr[wt] >= temp))
                        {
                            arr[wt + 1] = arr[wt];
                            wt--;
                        }
                        arr[wt + 1] = temp;
                    }
                    break;

            }
        }
    }
}
