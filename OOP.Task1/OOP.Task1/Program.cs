using System;

namespace OOP.Task1
{
    public class Square
    {

        public string a; // сторона квадрата
        public double S; // площадь квадрата
        public Square() { a = Console.ReadLine(); } // вводим значение внутри конутруктора    
        public void GetSquare() // процедура рассчета площади квадрата в случае успешного ввода
        {
            //S = a2
            double Size = Convert.ToDouble(a);
            S = Size * Size;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь квадрата =" + S);
        }

        public void GetRandomSquare() // процедура рассчета площади квадрата в случае, когда три попытки были неудачные 
        {
            Random rnd = new Random();
            double Size = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            S = Size * Size;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Сторона квадрата =" + Size);
            Console.WriteLine("Площадь квадрата =" + S);
        }
    }

    public class Circle
    {
        //S = π * r2
        public const double PI = 3.14;
        public string r; // радиус
        public double S; // площадь круга

        public Circle() { r = Console.ReadLine(); } // вводим значение внутри конутруктора 
        public void GetSquareCircle() // процедура рассчета площади круга в случае успешного ввода
        {
            double R = Convert.ToDouble(r);
            S = (R * R) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь круга =" + S);
        }

        public void GetRandomSquareCircle() // процедура рассчета площади круга в случае, когда три попытки были неудачные 
        {
            Random rnd = new Random();
            double R = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            S = (R * R) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Радиус =" + R);
            Console.WriteLine("Площадь круга =" + S);
        }

        public class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Вычисляем площадь квадрата, введите сторону квадрата");

                for (int i = 0; i <= 1; i++)
                {
                    try
                    {
                        Square test = new Square();
                        test.GetSquare();

                        break;
                    }
                    catch
                    {
                        if (i <= 1)
                            Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                        if (i == 1)
                        {
                            Square test = new Square();
                            test.GetRandomSquare();
                        
                        }
                    }

                }

                Console.WriteLine("Вычисляем площадь круга, введите радиус");

                for (int i = 0; i <= 1; i++)
                {
                    try
                    {
                        Circle test = new Circle();
                        test.GetSquareCircle();

                        break;
                    }
                    catch
                    {
                        if (i <= 1)
                            Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                        if (i == 1)
                        {
                            Circle test = new Circle();
                            test.GetRandomSquareCircle();

                        }
                    }
                }
            }
        }
    }
}

