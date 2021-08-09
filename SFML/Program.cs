using System;

namespace Random1
{
    class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            
           int randInt =  rand.Next(10, 100);
            Console.WriteLine(randInt);
            Console.WriteLine(rand.NextDouble());
            foreach(int number in MyIntArray())
            {
                Console.WriteLine(number);
            }

            foreach(double myDecimal in MyDoubleArray())
            {
                Console.WriteLine(myDecimal);
            }

            fizzBuzz(100);

            ADT myADT = new ADT();
            myADT.start = new Node();
            myADT.start.data = 1;
            myADT.start.next = new Node();
            myADT.start.next.data = 2;

            SFML_HelloWorld SFML_Demo = new SFML_HelloWorld();
            SFML_Demo.Run();

        }

        static int[] MyIntArray()
        {
            int[] myIntArray = new int[1000];
            for(int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = rand.Next(0, 1000);
            }

            return myIntArray;
        }

        static double[] MyDoubleArray()
        {
            double[] myDoubleArray = new double[1000];
            for (int i = 0; i < myDoubleArray.Length; i++)
            {
                int max = 1000;
                int min = 10;
                myDoubleArray[i] = rand.NextDouble() * (max-min) + min;
            }

            return myDoubleArray;
        }

        static void fizzBuzz(int max)
        {
            for(int i = 0; i < max+1; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
