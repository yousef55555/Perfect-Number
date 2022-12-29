using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // raed the input numbers start number and end number

            Console.WriteLine("Enter The Start Number: ");
            int startnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The End Number: ");
            int endnumber = int.Parse(Console.ReadLine());

            // find the perfect numbers between start number and end number 
            for (int i = startnumber; i <= endnumber; i++)
            {
                // check if i is a perfect number

                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
