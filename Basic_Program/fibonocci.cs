using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Program
{
    class fibonocci
    {
        

        int p1 = 0, p2 = 1, p3;
        public void Fibnocii()
        {
            Console.WriteLine("enter a value");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++) 
            {
                p3 = p1 + p2;
                p1 = p2;
                p2 = p3;
                Console.WriteLine(p3);
                count--;
                
            }
            
           


        }

    }
}
