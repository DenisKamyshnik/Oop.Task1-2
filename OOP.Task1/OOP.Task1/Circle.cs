using System;

namespace OOP.Task1
{
    public class Circle
    {
        private const double PI = 3.14;
        public double R { get; set; } 
        public double Diametr => InputAndValidation.GetRoundedValue(R * 2);
        public double S => InputAndValidation.GetRoundedValue((R * R) * PI);

        public Circle()
        {
            R = InputAndValidation.GetInput();
        }

        public void PrintRadius()
        {
            Console.WriteLine("Радиус = " + R);
        }

        public void PrintCircleArea()
        {
            Console.WriteLine("Площадь круга = " + S);
        }

    }

}
