using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_Java2NetAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumeros = { 5, 1, 2 };
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
                    arr = Array.FindAll(arr, i => i != min).ToArray();
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
                    arr = Array.FindAll(arr, i => i != max).ToArray();
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
