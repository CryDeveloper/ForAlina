using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAlina.Classes;

namespace ForAlina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool tryRead = false;
            while (!tryRead)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0)
                    {
                        throw new Exception("Время не может быть отрицательным.");
                    }
                    tryRead = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Zad1 myTask1 = new Zad1(a);
            myTask1.sm();

            Zad2 myTask2 = new Zad2();
            Console.WriteLine(myTask2);

            Console.ReadKey();
        }
    }
}
