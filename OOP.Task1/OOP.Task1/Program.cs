using System;

namespace OOP.Task1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисляем площадь квадрата, введите сторону квадрата");

            Square square = new Square();

            square.PrintSquareSide();

            square.PrintSquareArea();
                   
            Console.WriteLine("Вычисляем площадь круга, введите радиус");
          
            Circle circle = new Circle();

            circle.PrintRadius();

            circle.PrintCircleArea();

            if (circle.Diametr <= square.A)
            {
                Console.WriteLine("\nКруг помещается в квадрат, так как его диаметр " + circle.Diametr + " меньше или равен стороны квадрата " + square.A);
            }
            else
            { 
                Console.WriteLine("\nКруг не помещается в квадрат, так как его диаметр " + circle.Diametr + " больше стороны квадрата " + square.A);
            }
            if (square.Deagonal <= circle.Diametr)
            {
                Console.WriteLine("\nКвадрат помещается в круг, так как его диагональ " + square.Deagonal + " меньше или равна диаметру круга " + circle.Diametr);
            }
            else
            {
                Console.WriteLine("\nКвадрат не помещается в круг, так как его диагональ " + square.Deagonal + " больше диаметра круга " + circle.Diametr);
            }

            Console.ReadLine();

        }

    }

}




