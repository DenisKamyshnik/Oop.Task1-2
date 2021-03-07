using System;

namespace OOP.Task1
{
    public class Circle
    {
        private const double PI = 3.14;
        public double R { get; set; } 
        public double S { get; set; }

        InputAndValidation objinputAndValidation = new InputAndValidation();
        public double Diametr => objinputAndValidation.GetRoundedValue(R * 2);

        public Circle()
        {
            R = objinputAndValidation.Input();
            SetSquareCircle();
        }
    
        public void SetSquareCircle() 
        {
            S = (R * R) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Радиус = " + R);
            Console.WriteLine("Площадь круга = " + S);
        }

    }

}
