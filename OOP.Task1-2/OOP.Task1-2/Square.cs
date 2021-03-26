using System;

namespace OOP.Task1_2
{
    public class Square
    {
        public double A { get; set; }

        public double Deagonal => InputAndValidation.GetRoundedValue(A * Math.Sqrt(2));

        public double S => InputAndValidation.GetRoundedValue(A * A);

        public Square()
        {
            A = InputAndValidation.GetInput();
        }

        public void PrintSquareSide()
        {
            Console.WriteLine("Сторона квадрата = " + A);
        }

        public void PrintSquareArea()
        {
            Console.WriteLine("Площадь квадрата = " + S);
        }

    }
}