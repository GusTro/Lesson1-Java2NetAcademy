using System;

namespace Lesson1_Java2NetAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrElementos = { "A", "B", "C","D" };
            Console.Write("Escriba el elemento que quiere encontrar: ");
            var word = Console.ReadLine();
            FindWord(arrElementos, word.ToString());
        }
        
        static void FindWord(string[] arr, string item)
        {
            int count = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if (item == arr[i])
                    Console.WriteLine("Si se encontro el elemento " + item);
                else
                    count++;
                if (count == arr.Length)
                {
                    Console.WriteLine("No se encontro el elemento que esta buscando");
                }
            }
        }
    }
}
