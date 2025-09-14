using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public static class DSA
    {
        public static void SortingIntArray()
        {
            int[] IntArray = { 2, 29, 6, 77, 3, 11, 8, 88, 4, 99 };
            for (int i = 0; i <= IntArray.Length - 1; i++)
            {
                for (int j = i + 1; j <= IntArray.Length - 1; j++)
                {
                    if (IntArray[i] > IntArray[j])
                    {
                        int temp = IntArray[i];
                        IntArray[i] = IntArray[j];
                        IntArray[j] = temp;
                    }
                }
            }
            //IntArray = IntArray.OrderBy(c => c).ToArray();
            Console.WriteLine(string.Join(',', IntArray));
        }
        public static void SortingStringArray()
        {
            string[] StringArray = { "Zebra", "Apple", "Mango", "Banana", "Orange" };
            //for (int i = 0; i <= StringArray.Length - 1; i++)
            //{
            //    for (int j = i + 1; j <= StringArray.Length - 1; j++)
            //    {
            //        if (String.Compare(StringArray[i], StringArray[j]) > 0)
            //        {
            //            string temp = StringArray[i];
            //            StringArray[i] = StringArray[j];
            //            StringArray[j] = temp;
            //        }
            //    }
            //}
            StringArray = StringArray.OrderBy(c => c).ToArray();
            Console.WriteLine(string.Join(',', StringArray));
        }

        public static void Find2ndHighestNumber()
        {
            int[] array = { 1, 3, -1, 2, -4, 9, 11 };
            int max = 0, max2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max2 = max; // Assign the current max to max2 before updating max
                    max = array[i];
                }
                else if (max2 < array[i] && max != array[i])
                {
                    max2 = array[i];
                }
            }
            List<int> list = new List<int>() { max, max2 };
            Console.WriteLine(string.Join(',', list));
        }
        public static void Find3rdHighestNumber()
        {
            //int[] array = { 1, 3, -1, 2, -4, 9, 11 };
            int[] array = { 2, 1, 3, -1, 5, -4, 6, 4 };
            int max = 0, max2 = 0, max3 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max3 = max2; // Assign the current max2 to max3 before updating max2
                    max2 = max; // Assign the current max to max2 before updating max
                    max = array[i];
                }
                else if (max2 < array[i] && max != array[i])
                {
                    max2 = array[i];
                }
                else if (max3 < array[i] && max2 != array[i] && max != array[i])
                {
                    max3 = array[i];
                }
            }
            List<int> list = new List<int>() { max, max2, max3 };
            Console.WriteLine(string.Join(',', list));
        }
    }
}
