using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Задача.
 Найти два числа из массива, в сумме равных числу к.
    Решение с помощью бинарного поиска.  */

namespace twoSum_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -7, 0, 2, 3, 6, 8, 10, 15, 18 };
            int k = 10;
            int[] res = new int[] {0, 0};
                                    
            for (int i = 0; i < nums.Length; i++)
            {
                int numberToFind = k - nums[i];
                int left = i + 1;
                int right = nums.Length - i;
                
                while (left <= right)
                {
                    int middle = left + (right - left) / 2;
                    if (nums[middle] == numberToFind)
                        {
                            res = new int[] { nums[i], numberToFind };
                        }
                    if (numberToFind < nums[middle])                    
                        right = middle - 1;                    
                    else                    
                        left = middle + 1;                    
                }
            }
            Console.WriteLine($"[{res[0]}, {res[1]}]");
            Console.ReadKey();
        }
    }
}
