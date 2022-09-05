using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BubbleSort
    {
        public BubbleSort(params string[] arr)
        {

            int i, j;
            string temp;
            Console.Write("\nBefore Bubble sorting the elements are : \n");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("\n\nAfter Bubble sorting the elements are : \n");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
