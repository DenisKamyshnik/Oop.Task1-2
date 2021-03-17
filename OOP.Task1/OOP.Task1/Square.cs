using System;

namespace OOP.Task1
{
    public class Square
    {
        public double A { get; set; }          
      //  private double S { get; set; } 

        public double Deagonal => InputAndValidation.GetRoundedValue(A * Math.Sqrt(2));

        public double S => InputAndValidation.GetRoundedValue(A * A);

        public Square()  
        {
            A = InputAndValidation.GetInput();
            //SetSquareOfSquare();
        }

   /*     private void SetSquareOfSquare() 
        {
            S = A * A;
            S = Math.Round(S * 100.0) / 100.0;       
        }*/

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
