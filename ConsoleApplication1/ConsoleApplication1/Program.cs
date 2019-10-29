using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            int a = 0, b = 100;
            int count = 1;
            while(b > a+1)
            {
                int c = (a + b) / 2;
                Console.Write("Q{0}: Is your number less than {1}?",count ,c);
                ans = Console.ReadLine();
                if (ans == "Y")
                    b = c - 1;
                if (ans == "N")
                    a = c;
                count++;
            }
            Console.Write("Is your number {0}?", a);
            ans = Console.ReadLine();
            if (ans == "Y")
                Console.Write("Your number is {0} ", a);
            if (ans == "N")
                Console.Write("Your number is {0} ", b);

            //int a=0, b=100, c=(a+b)/2;
            //Console.Write("Is your number larger than 50? T or F?");
            ////for (int i = 0; i <= 100; i++)
            ////{   
            //if (Console.ReadLine() == "T")
            //{
            //    a = c;
            //    Console.Write("Is Your number larger than {0}? T or F?", c);
            //    if (Console.ReadLine() == "T")
            //    {
            //        a = c;
            // }       
            //}     
            //else if(Console.ReadLine()=="F")
            //{
            //    b = c;
            //}
            //if (Console.ReadLine() == "T")
            //    b = c;
            //else if (Console.ReadLine() == "F")
            //    a =c;
            //}
            
        }
    }
}
