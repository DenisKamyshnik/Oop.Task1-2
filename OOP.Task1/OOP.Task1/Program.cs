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
            if (objCircle.GetDiametr() <= objSquare.A)
            {
                Console.WriteLine("Круг помещается в квадрат, так как его диаметр " + objCircle.GetDiametr() + " меньше или равен стороны квадрата " + objSquare.A);               
            }
            else
            { 
                Console.WriteLine("Круг не помещается в квадрат, так как его диаметр " + objCircle.GetDiametr() + " больше стороны квадрата " + objSquare.A);
            }
            if (objSquare.GetDeagonal() <= objCircle.GetDiametr())
            {
                Console.WriteLine("Квадрат помещается в круг, так как его диагональ " + objSquare.GetDeagonal() + " меньше или равна диаметру круга " + objCircle.GetDiametr());
            }
            else
            {
                Console.WriteLine("Квадрат не помещается в круг, так как его диагональ " + objSquare.GetDeagonal() + " больше диаметра круга " + objCircle.GetDiametr());
            }
        }
    }
}




