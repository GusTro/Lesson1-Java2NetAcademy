using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_Java2NetAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumeros = { 3, 2, 2, 7, 9 };
            int[] arrSortAsc = OrderByAsc(arrNumeros);
            int[] arrSortDesc = OrderByDesc(arrNumeros);
            SortOrderByAscConsole(arrSortAsc);
            Console.WriteLine("");
            SortOrderByDescConsole(arrSortDesc);
        }
        static int[] OrderByAsc(int[] arr)
        {
            List<int> arrTemp = new List<int>();
            int min = arr[0];
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(min <= arr[i])
                {
                    count++;
                }
                else
                {
                    min = arr[i];
                    count = 0;
                    i = -1;
                }
                if(count == arr.Length)
                {
                    arrTemp.Add(min);
                    int indexToRemove = Array.FindIndex(arr, x => x == min);
                    arr = arr.Where((source, index) => index != indexToRemove).ToArray();
                    if (arr.Length == 0)
                        break;
                    min = arr[0];
                    i = -1;
                    count = 0;
                }
            }
            return arrTemp.ToArray();
        }

        static int[] OrderByDesc(int[] arr)
        {
            List<int> arrTemp = new List<int>();
            int max = arr[0];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= max)
                {
                    count++;
                }
                else
                {
                    max = arr[i];
                    count = 0;
                    i = -1;
                }
                if (count == arr.Length)
                {
                    arrTemp.Add(max);
                    int indexToRemove = Array.FindIndex(arr, x => x == max);
                    arr = arr.Where((source, index) => index != indexToRemove).ToArray();
                    if (arr.Length == 0)
                        break;
                    max = arr[0];
                    i = -1;
                    count = 0;
                }
            }
            return arrTemp.ToArray();
        }

        static void SortOrderByAscConsole(int[] arr)
        {
            Console.Write("Array Order By Asc: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
        }

        static void SortOrderByDescConsole(int[] arr)
        {
            Console.Write("Array Order By Desc: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
