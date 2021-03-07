using System;

namespace OOP.Task1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисляем площадь квадрата, введите сторону квадрата");

            Square objSquare = new Square();
                   
            Console.WriteLine("Вычисляем площадь круга, введите радиус");
          
            Circle objCircle = new Circle();

            if (objCircle.Diametr <= objSquare.A)
            {
                Console.WriteLine("Круг помещается в квадрат, так как его диаметр " + objCircle.Diametr + " меньше или равен стороны квадрата " + objSquare.A);
            }
            else
            { 
                Console.WriteLine("Круг не помещается в квадрат, так как его диаметр " + objCircle.Diametr + " больше стороны квадрата " + objSquare.A);
            }
            if (objSquare.Deagonal <= objCircle.Diametr)
            {
                Console.WriteLine("Квадрат помещается в круг, так как его диагональ " + objSquare.Deagonal + " меньше или равна диаметру круга " + objCircle.Diametr);
            }
            else
            {
                Console.WriteLine("Квадрат не помещается в круг, так как его диагональ " + objSquare.Deagonal + " больше диаметра круга " + objCircle.Diametr);
            }

            Console.ReadLine();

        }

    }

}




