using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            
            int[] myArray = new int[15];
            
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                myArray[i] = random.Next(0, 50);
                Console.WriteLine("{0} ", myArray[i]);
            }
            Console.WriteLine();
            int max = myArray[0];
            int min = myArray[0];

            foreach (int a in myArray)
            {
                if (a > max)
                    max = a;
            }

            foreach (int b in myArray)
            {
                if (b < min)
                    max = b;
            }
            Console.WriteLine("Наибольшее значение равно {0} ", (max));
            Console.WriteLine("Наименьшее значение равно {0} ", (min));
            Console.WriteLine("Сумма наибольшего и наименьшего значений равна {0} ", (max + min));
            Console.ReadKey();
        }
                                    
    }   
}