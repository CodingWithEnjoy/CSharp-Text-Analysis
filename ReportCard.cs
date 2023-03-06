using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication73
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            List<string> dars = new List<string>();
            List<double> nomre = new List<double>();
            List<double> moadel = new List<double>();

            Console.Write("Enter Names Count : ");
            int td = int.Parse(Console.ReadLine());
            Console.Write("Enter Lessons Count : ");
            int tdd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= td; i++)
            {
                double q = 0;
                double s = 0;

                Console.Write("Enter Name : ");
                name.Add(Console.ReadLine());

                for (int j = 0; j < tdd; j++)
                {
                    Console.Write("Enter Lesson Name : ");
                    dars.Add(Console.ReadLine());

                    Console.Write("Enter Score : ");
                    double x = double.Parse(Console.ReadLine());
                    nomre.Add(x);
                    q += x;
                    s++;
                }

                moadel.Add(q / s);
            }

            for (int c = 0; c < name.Count; c++)
            {
                Console.WriteLine("Name : " + name[c]);

                for (int h = 0; h < dars.Count; h++)
                {
                    Console.WriteLine(dars[h] + " " + nomre[h]);
                }

                Console.Write("Average : " + moadel[c]);
            }

            Console.ReadKey();
        }
    }
}
