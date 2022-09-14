using System;

namespace Basic_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for add");
            Console.WriteLine("Enter 2 for sub");
            Console.WriteLine("Enter 3 for mul");
            Console.WriteLine("Enter 4 for div");
            Console.WriteLine("Enter 5 for fibnocii");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    add _add = new add();
                    
                    int res = _add.Add();
                    Console.WriteLine(res);
                    
                    
                    break;
                case 2:
                    add _sub = new add();

                    int res1 = _sub.Sub();
                    Console.WriteLine(res1);

                    break;
                case 3:
                    add _mul = new add();

                    int res2 = _mul.Mul();
                    Console.WriteLine(res2);

                    break;
                case 4:
                    add _div = new add();

                    double res3 = _div.Div();
                    Console.WriteLine(res3);
                    break;

                case 5:
                    fibonocci fi = new fibonocci();
                    fi.Fibnocii();

                   
                    

                    break;
                    default:
                    Console.WriteLine("failed");
                    break ;
            }
            
           
        }
    }
}
