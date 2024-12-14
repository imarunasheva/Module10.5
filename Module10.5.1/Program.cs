using System;
using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;

namespace Module10._5._1
{
    class Program
    {       
        
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            while (true) 
            {
                try
                {
                    Logger = new Logger();

                    Console.Write("Введите первое значение: ");
                    var a = decimal.Parse(Console.ReadLine());
                    Console.Write("Введите второе значение: ");
                    var b = decimal.Parse(Console.ReadLine());

                    var calc = new Calc(Logger);
                    calc.CalLog();
                    var result = calc.Sum(a, b);
                    Console.WriteLine("Сумма чисел: " + result);

            }
                catch (FormatException)
                {
                    Logger.Error("Ошибка: введите числовое значение");
                }
            }
            
        }
    }
}