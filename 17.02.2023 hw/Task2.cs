using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02._2023_hw
{
    static class PrintDateTime
    {
        public delegate void Delegate();
        public static void NowTime()
        { 
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.TimeOfDay.ToString());
        }
        public static void NowDate()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.Date.ToString());
        }
        public static void NowDayOfWeek()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.DayOfWeek.ToString());
        }
    }
    interface IFigure
    {
        float GetSquare();
    }
    static class Square
    {
        public delegate float Delegate(IFigure figure);
        public static float Rectangle(IFigure figure)
        { 
            return (float)figure.GetSquare();
        }
        public static float Triangle(IFigure figure)
        {
            return (float)figure.GetSquare();
        }
    }
}
