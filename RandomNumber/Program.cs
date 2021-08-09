using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[100];
            for(var i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(10, 20);
            }

            for(int i=0; i<myArray.Length; i++)
            {
                if(myArray[i] == 17)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            
        }
    }
}
