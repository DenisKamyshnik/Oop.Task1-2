using System;
using System.Collections.Generic;
using System.Text;


namespace OOP.Task1
{
    class InputAndValidation
    {
       public double GetRoundedValue(double value)
        {           
            return value = Math.Round(value * 100.0) / 100.0;
        }

        public double GetRandomValue(double value)
        {
            Random rnd = new Random();
            value = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            return value;
        }

        public double Input()
        {
           
            double inputResult = 0;
            for (int i = 0; i <= 2; i++)
            {         
                String input = Console.ReadLine();

                if (input.Contains("."))
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                }
                else
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru");
                }

                if (double.TryParse(input, out inputResult) && inputResult > 0)
                {
                   inputResult = GetRoundedValue(inputResult);
                    break;
                }
                else if (i < 2)
                {
                    Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                }
                if (i == 2)
                {
                    inputResult = GetRandomValue(inputResult);
                    inputResult = GetRoundedValue(inputResult);                   
                }
                
            }
            return inputResult;
        }

    }

}
