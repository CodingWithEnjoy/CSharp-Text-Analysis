using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Text : ");

            string x;
            x = Console.ReadLine();

            int a = 0, b = 0, c = 0, d = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 'a' && x[i] <= 'z')
                    a++;

                else
                    if (x[i] >= 'A' && x[i] <= 'z')
                    b++;

                else
                        if (x[i] >= '0' && x[i] <= '9')
                    c++;

                else
                    d++;
            }

            Console.WriteLine("Number of lowercase letters: " + a);
            Console.WriteLine("Number of uppercase letters: " + b);
            Console.WriteLine("Number of digits: " + c);
            Console.WriteLine("Number of other characters: " + d);

            Console.ReadKey();
        }
    }
}
