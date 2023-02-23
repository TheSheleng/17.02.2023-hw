using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _17._02._2023_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 4, 2, 4, 3, 5, 1, 7, 6 };
            //GetByArr.Int method = GetByArr.Even;
            //method += GetByArr.Fibonacci;

            //var result = method.Invoke(arr);
            //foreach (var i in result) { Console.WriteLine(i); }

            PrintDateTime.Delegate method = PrintDateTime.NowDate;
            method();

            Console.ReadKey();
        }
    }
}
