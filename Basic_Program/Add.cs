using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Program
{
    public class add
    {
       
        public int Add()
        {
            
            Console.WriteLine("please enter the Number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }

        public int Sub()
        {
            Console.WriteLine("please enter the Number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            int b = Convert.ToInt32(Console.ReadLine());

            return a - b;
        }
        public int Mul()
        {
            Console.WriteLine("please enter the Number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            int b = Convert.ToInt32(Console.ReadLine());

            return a * b;
        }
        public double Div()
        {
            Console.WriteLine("please enter the Number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            int b = Convert.ToInt32(Console.ReadLine());

            return a / b;
        }
    }
}
