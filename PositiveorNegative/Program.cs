using System;

namespace PositiveorNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            if(a<0)
            {
                Console.WriteLine(a.ToString()+ "  is negative" );
            }
            else
            {
                Console.WriteLine(a.ToString()+" is positive");
            }
            
        }
    }
}
