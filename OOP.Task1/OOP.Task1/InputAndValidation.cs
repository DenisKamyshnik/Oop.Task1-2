using System;


namespace OOP.Task1
{
    public static class InputAndValidation
    {
        public const int Tries = 3;
        public static double GetRoundedValue(double value)
        {           
            return Math.Round(value * 100.0) / 100.0;
        }

        public static  double GetRandomValue(double value)
        {
            Random rnd = new Random();
            return (rnd.NextDouble() * (5 - 0.5)) + 0.5; 
        }

        public static double GetInput()
        {
           
            double inputResult = 0;
            for (int i = 0; i <= Tries-1; i++)
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
                else if (i < Tries-1)
                {
                    Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                }
                if (i == Tries-1)
                {
                    inputResult = GetRandomValue(inputResult);
                    inputResult = GetRoundedValue(inputResult);                   
                }
                
            }
            return inputResult;
        }

    }

}
