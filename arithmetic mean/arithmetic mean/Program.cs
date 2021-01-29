using System;
using System.Collections.Generic;
using System.Linq;


namespace arithmetic_mean
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input number and stop when ready");

            List<double> numbers = new List<double>();


            while (true)
            {
                string str = Console.ReadLine();
                if (str.Equals("stop"))
                {
                    Console.WriteLine("Average = " + numbers.Average());
                    Console.ReadLine();

                    return;
                }
                else
                {
                    try {
                        double number = double.Parse(str);
                        numbers.Add(number);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("BOLVAN !!!!");
                    }
                    
                }
            }
            
        
        }
    }
}
