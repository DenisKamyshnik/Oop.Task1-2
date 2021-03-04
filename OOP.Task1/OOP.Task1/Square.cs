using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task1
{
    public class Square
    {
        //S = a * a
        private double _a; // сторона квадрата
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        
        private double _S; // площадь квадрата

        public double S
        {
            get { return _S; }
            set { _S = value; }
        }
        public Square()  // вводим значение внутри конутруктора  
        {

            Result();

        }

        public double GetDeagonal()
        {
            return A * Math.Sqrt(2);
        }
      
        private void Result()
        {
            for (int i = 0; i <= 2; i++)
            {

                String inputA = Console.ReadLine();

                if (double.TryParse(inputA, out _a))
                {
                    _a = Convert.ToDouble(inputA);
                    SSquare();
                    break;

                }
                else if (i < 2)
                {
                    Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                }
                if (i == 2)
                {

                    RandomSquare();


                }

            }
        }
        private double GetRandomSide()
        {

            Random rnd = new Random();
            A = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            return A;
        }


        private void SSquare() // процедура рассчета площади квадрата в случае успешного ввода
        {

            double Size = Convert.ToDouble(_a);
            S = Size * Size;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь квадрата = " + S);
        }


        private void RandomSquare() // процедура рассчета площади квадрата в случае, когда три попытки были неудачные 
        {
            double randomA = GetRandomSide();
            S = randomA * randomA;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Сторона квадрата = " + randomA);
            Console.WriteLine("Площадь квадрата = " + S);
        }
    }
}
