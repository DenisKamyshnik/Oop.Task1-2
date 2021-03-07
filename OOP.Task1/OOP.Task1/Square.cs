using System;

namespace OOP.Task1
{
    public class Square
    {
        public double A { get; set; }          
        private double S { get; set; } 

        InputAndValidation objinputAndValidation = new InputAndValidation();
        public double Deagonal => objinputAndValidation.GetRoundedValue(A * Math.Sqrt(2));

        public Square()  
        {
            A = objinputAndValidation.Input();
            SetSquareOfSquare();
        }

        private void SetSquareOfSquare() 
        {
            S = A * A;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Сторона квадрата = " + A);
            Console.WriteLine("Площадь квадрата = " + S);
        }

    }
}
