using System;

namespace HypotCalc2
{
    class Program
    {
        static void Main(string[] args)
        {
			
				double a = 0.0;
				double b = 0.0;
				double c = 0.0;
				string temp;
				//read in the miles

				Console.WriteLine("Enter a");
				temp = Console.ReadLine();
				a = Double.Parse(temp);
				//read in the gallons
				Console.WriteLine("Enter b");
				temp = Console.ReadLine();
				b = Double.Parse(temp);
				//compute the miles per gallons
				c = Math.Sqrt((a * a) + (b * b));
				Console.WriteLine("C is equal to " + c);
			
		}
    }
}
