using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task1
{
    public class Circle
    {
        //S = π * r * r
        private const double _PI = 3.14;

        private double _r; // радиус

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        private double _S; // площадь круга

        public double S
        {
            get { return _S; }
            set { _S = value; }
        }

        public Circle() // вводим значение внутри конутруктора 
        {
            Result();
        }
        private void Result()
        {
        
            for (int i = 0; i <= 2; i++)
            {

                String inputR = Console.ReadLine();

                if (double.TryParse(inputR, out _r))
                {
                    _r = Convert.ToDouble(inputR);
                    SquareCircle();
                    break;

                }
                else if (i < 2)
                {
                    Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                }
                if (i == 2)
                {

                    RandomSquareCircle();


                }

            }
        }

        private void SquareCircle() // процедура рассчета площади круга в случае успешного ввода
        {

            S = (R * R) * _PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь круга = " + S);

        }
        public double GetDiametr()
        {
            return R * 2;
        }
        private double RandomRadius()
        {
            Random rnd = new Random();
            R = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            return R;
        }

        private void RandomSquareCircle() // процедура рассчета площади круга в случае, когда три попытки были неудачные 
        {
            double randomR = RandomRadius();
            S = (randomR * randomR) * _PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Радиус = " + randomR);
            Console.WriteLine("Площадь круга = " + S);

        }

    }
}
