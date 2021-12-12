using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int s = 0;

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива:");

            for (int i = 0; i < myArray.Length; i++)
            {

                Console.WriteLine(myArray[i]);
                s = s + myArray[i];
            }

            Console.WriteLine("Среднее арифметическое чисел равно {0}", s / elementsCount);
            Console.ReadKey();
        }

    }
}