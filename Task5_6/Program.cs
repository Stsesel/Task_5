using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размерность массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());
                               
            
            int[,] myArray = new int[elementsCount, elementsCount];
            

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + " X: "+j);
                    myArray[i,j] = int.Parse(Console.ReadLine());
                }
            }


            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
                       
            }

           
            
            int sumString = 0;

                        
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    sumString += myArray[y, x];
                    Console.Write(sumString + "\t");
                }
                Console.WriteLine();

            }
            
            
            Console.WriteLine("Сумма {0}",sumString);
            Console.ReadKey();




        }

    }
}