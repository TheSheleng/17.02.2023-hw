using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2023_hw
{
    static class GetByArr
    {
        public delegate int[] Int(int[] arr);
        public static int[] Even(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (var item in arr) if (item % 2 == 0) list.Add(item);
            return list.ToArray();
        }
        public static int[] NotEven(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (var item in arr) if (item % 2 != 0) list.Add(item);
            return list.ToArray();
        }
        public static int[] Prime(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (var item in arr)
            { 
                int center = item % 2;
                for (float i = 0; i < center; i++)
                {
                    float checking = item / i;
                    if (checking == Convert.ToInt32(checking))
                    {
                        list.Add(item);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
        public static int[] Fibonacci(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (var item in arr)
            {
                for (int num = 1, last = 1; num <= item; (num, last) = (num + last, num))
                {
                    if (item == num)
                    {
                        list.Add(item);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
    }
}
