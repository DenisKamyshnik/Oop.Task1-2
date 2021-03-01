using System;

namespace OOP.Task1
{
    public class Square
    {

        private double a; // сторона квадрата
        private double S; // площадь квадрата
        public Square()  // вводим значение внутри конутруктора  
        {
            
            this.GetResult();

        }
        
        public double GetDeagonal()
        {
            return a * Math.Sqrt(2);
        }
        public double getA()
        {
            return a;
        }
        private void GetResult()
        {
            for (int i = 0; i <= 2; i++)
            {

                String sa = Console.ReadLine();
                bool result = double.TryParse(sa, out a);

               if (result == true) {
               a = Convert.ToDouble(sa);
                GetSquare();
                    break;
                    
                }
                else if (i<2)
                {
                    Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                }
                if (i == 2)
                {
                
                GetRandomSquare();
                   

                }
               
            }        
        }
        private double GetRandomSide()
        {
           
            Random rnd = new Random();
            a = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            return a;
        }


        private void GetSquare() // процедура рассчета площади квадрата в случае успешного ввода
        {
           
            double Size = Convert.ToDouble(a);
            S = Size * Size;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь квадрата = " + S);
        }


        private void GetRandomSquare() // процедура рассчета площади квадрата в случае, когда три попытки были неудачные 
        {
           double a = GetRandomSide();
            S = a * a;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Сторона квадрата = " + a);
            Console.WriteLine("Площадь квадрата = " + S);
        }
    }
   

    public class Circle
    {
        //S = π * r2
        private const double PI = 3.14;
        private double r; // радиус
        private double S; // площадь круга
        
        public Circle() // вводим значение внутри конутруктора 
        {
            this.GetResult();
        }
        private void GetResult()
        {
            double R;
            for (int i = 0; i <= 2; i++)
            {

                String sr = Console.ReadLine();
                bool result = double.TryParse(sr, out R);

                if (result == true)
                {
                    r = Convert.ToDouble(sr);
                    GetSquareCircle();
                    break;

                }
                else if (i < 2)
                {
                    Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                }
                if (i == 2)
                {

                    GetRandomSquareCircle();


                }

            }
        }

        private void GetSquareCircle() // процедура рассчета площади круга в случае успешного ввода
        {
            
            S = (r * r) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь круга = " + S);
            
        }
        public double GetDiametr()
        {
            return r * 2;
        }
        private double GetrandomRadius()
        {
            Random rnd = new Random();
            r = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            return r;
        }

        private void GetRandomSquareCircle() // процедура рассчета площади круга в случае, когда три попытки были неудачные 
        {
            double r = GetrandomRadius();
            S = (r * r) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Радиус = " + r);
            Console.WriteLine("Площадь круга = " + S);

        }

    }

    public class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Вычисляем площадь квадрата, введите сторону квадрата");

            Square test = new Square();
                   
            Console.WriteLine("Вычисляем площадь круга, введите радиус");

            Circle test1 = new Circle();
            if (test1.GetDiametr() <= test.getA())
            {
                Console.WriteLine("Круг помещается в квадрат, так как его диаметр " + test1.GetDiametr() + " меньше или равен стороны квадрата " + test.getA());               
            }
            else
            { 
                Console.WriteLine("Круг не помещается в квадрат, так как его диаметр " + test1.GetDiametr() + " больше стороны квадрата " + test.getA());
            }
            if (test.GetDeagonal() <= test1.GetDiametr())
            {
                Console.WriteLine("Квадрат помещается в круг, так как его диагональ " + test.GetDeagonal() + " меньше или равна диаметру круга " + test1.GetDiametr());
            }
            else
            {
                Console.WriteLine("Квадрат не помещается в круг, так как его диагональ " + test.GetDeagonal() + " больше диаметра круга " + test1.GetDiametr());
            }
        }
    }
}




