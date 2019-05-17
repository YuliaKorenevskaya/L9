using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    public static class Dt
    {          
        public static void Deconstruct(this DateTime date, out int day, out int month, out int year, out int hour, out int minute, out int second) =>
        (day, month, year, hour, minute, second) = (date.Day, date.Month, date.Year, date.Hour, date.Minute, date.Second);
    }
    class Program
    {              
        public static void Main()
        {
            DateTime date = DateTime.Now; 
            Console.WriteLine("Текущая дата: {0}", date);
            var (_, _, _, hour, minute, second) = date;
            Console.WriteLine($"Время {hour}:{minute}:{second}");
            Console.ReadKey();
        }
    }
}
