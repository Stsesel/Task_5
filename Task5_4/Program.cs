using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] myArray = new int[20];

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                myArray[i] = random.Next(-50, 50);
                Console.WriteLine("{0} ", myArray[i]);
            }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < 20; i++)
            {
              
                    if (myArray[i] > 0)
                    {
                        
                        if (i % 2 == 0)
                        {
                            if (myArray[i] % 2 == 1)
                            {
                            count++;
                            }
                        }



                    }

               

            }
            Console.WriteLine();
                                  
            Console.Write("{0}  ", count);
            Console.ReadKey();

        }

    }
}