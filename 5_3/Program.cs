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


            int[] myArray = new int[10];

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                myArray[i] = random.Next(-50, 50);
                Console.WriteLine("{0} ", myArray[i]);
            }
            Console.WriteLine();
            


            for (int i = 0; i <4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                                            
                        if (myArray[i] > myArray[j])
                        {
                            int t = myArray[i];
                            myArray[i] = myArray[j];
                            myArray[j] = t;
                        }


                }

            }
            Console.WriteLine();




            for (int i = 5; (i >4 && i < 9); i++)
            {
                for (int k = i+1; k < 10; k++)
                {
                    

                        if (myArray[i] < myArray[k])
                        {
                            int r = myArray[i];
                            myArray[i] = myArray[k];
                            myArray[k] = r;
                        }


                }

            }
            Console.WriteLine();


            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", myArray[i]);
            }
            Console.ReadKey();
        }

    }
}