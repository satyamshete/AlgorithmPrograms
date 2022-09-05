using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class InsertionSort
    {
        public InsertionSort(params string[] arr)
        {
            Console.Write("\nBefore Insertion sorting the elements appears like : \n");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            for (var i = 1; i < arr.Length; i++)
            {
                var current = arr[i];

                var j = i - 1;
                while (j >= 0 && arr[j].ToLower().CompareTo(current.ToLower()) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }
            Console.Write("\nAfter Insertion sorting the elements appears like : \n");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
