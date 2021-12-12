using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[,] myArray = new int[elementsCount, elementsCount];
            Random random = new Random();

                       
            
            for (int i = 0; i < elementsCount; i++)
            {
                
                for (int j =0; j < elementsCount; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            myArray[i, j] = random.Next(1, 1);
                            Console.Write("{0}", myArray[i,j]);
                        }

                        if (j % 2 == 0)
                        {
                            myArray[i, j] = random.Next(0, 0);
                            Console.Write("{0}", myArray[i, j]);
                        }
                    }



                                      
                    
                    
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 1)
                        {
                            myArray[i, j] = random.Next(0, 0);
                            Console.Write("{0}", myArray[i, j]);
                        }

                        if (j % 2 == 0)
                        {
                            myArray[i, j] = random.Next(1, 1);
                            Console.Write("{0}", myArray[i, j]);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

    }
}