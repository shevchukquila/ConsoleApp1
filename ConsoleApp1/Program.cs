using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Введите слово=");
            //string m = Console.ReadLine();  
            //for (int i = 1; i <=n; i++)
            //{
            //    Console.WriteLine(m);
            //}
            //Задание 2
            //for (int i = 10;i < 100; i++) 
            //{
            //    Console.WriteLine(i);
            //}
            //Задание 3
            //for (int i = 11; i < 100; i++)
            //{
            //    if (i%11== 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Задание 4
            //int y = 0;
            //for (int i = 10; i < 100; i++) 
            //{
            //    if (i%16==0) 
            //    {
            //        Console.WriteLine(i);
            //        y++;
            //    }
            //}
            //Console.WriteLine($"Кол-во = {y}");
            //Задание 5
            //int y = 0, k = 0;
            //for (int i = 10; i < 100; i++)
            //{
            //    if (i % 25 == 0)
            //    {
            //        Console.WriteLine(i);
            //        y++;k += i;
            //    }
            //}
            //Console.WriteLine($"Кол-во = {y}");
            //Console.WriteLine($"Сумма = {k}");
            //Задание 6
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int y = 1; y <= 7; y++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Задание 7
            for (int i = 1; i <= 15; i++)
            {
                for (int y = 1; y <= 7; y++)
                {
                    Console.Write("#   ");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}