using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReverseTry_CodeSignal_Core_Test37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = firstReverseTry(array);
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            
        }

        static int[] firstReverseTry(int[] arr)
        {
            if (arr.Length > 1)
            {
                int temp = arr[0];
                arr[0] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
                return arr;
            }
            else if (arr.Length == 0)
            {
                return arr;
            }
            return arr;

        }
    }
}
