using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, twovalue;
            string operatorA;

            Console.WriteLine("Введи первое число: ");
            firstvalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            twovalue = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Что делаем?: + | - | / | * |");
            operatorA = Console.ReadLine();

            switch (operatorA)
            {
                case "+":
                    Console.WriteLine(firstvalue + twovalue);
                    break;

                case "-":
                    Console.WriteLine(firstvalue - twovalue);   
                    break;
                
                case "*":
                    Console.WriteLine(firstvalue * twovalue);
                    break;

                case "/":
                    if (firstvalue == 0)
                        Console.WriteLine(0);
                    else if (twovalue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstvalue / twovalue);
                    break;

                    default:
                    Console.WriteLine("Неизвестно");
                        break;
            }
            Console.ReadKey();
        }

    }
}
