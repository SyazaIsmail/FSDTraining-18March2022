using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithm
{
    class LinearSearch
    {
        int[] array = { 59, 23, 61, 90, 33, 2, 30 };
    }
    // T(n) => O(n)
    public static void Do()
    {
        Console.WriteLine("Please enter a number to search in array");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == num)
            {
                Console.WriteLine("Number found at index " = i);
                return;
            }
        }
        Console.WriteLine("Number not found in array");
    }
}
