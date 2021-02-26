using System;

namespace OOP.Task1
{
    public class Square
    {

       static public string a; // сторона квадрата
        public double S; // площадь квадрата
        public Square()  // вводим значение внутри конутруктора  
        {
            
            this.GetResult();

        }
        public void GetResult()
        {
            double A;
            for (int i = 0; i <= 2; i++)
            {

                a = Console.ReadLine();
                bool result = double.TryParse(a, out A);

               if (result == true) {
               A = Convert.ToDouble(a);
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
        public double GetRandomSide()
        {
           
            Random rnd = new Random();
            double a = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            return a;
        }

       /* public double GetSide()
        {
            try
            {
                double A = Convert.ToDouble(a);
                return A;
            }
            catch
            {
                double A = GetRandomSide();
                return A;
            }
           
            
        }*/

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
           double a = GetRandomSide();
            S = a * a;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Сторона квадрата =" + a);
            Console.WriteLine("Площадь квадрата =" + S);
        }
    }
   

    public class Circle
    {
        //S = π * r2
        public const double PI = 3.14;
        public string r; // радиус
        public double S; // площадь круга
        
        public Circle() // вводим значение внутри конутруктора 
        {
            this.GetResult();
        }
        public void GetResult()
        {
            double R;
            for (int i = 0; i <= 2; i++)
            {

                r = Console.ReadLine();
                bool result = double.TryParse(r, out R);

                if (result == true)
                {
                    R = Convert.ToDouble(r);
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

        public void GetSquareCircle() // процедура рассчета площади круга в случае успешного ввода
        {
            double R = Convert.ToDouble(r);
            S = (R * R) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Площадь круга =" + S);
            
        }
      /*  public double GetDiameter()
        {
            double R = Convert.ToDouble(r);
            return R * 2;
        }*/

        public void GetRandomSquareCircle() // процедура рассчета площади круга в случае, когда три попытки были неудачные 
        {
            Random rnd = new Random();
            double R = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
            S = (R * R) * PI;
            S = Math.Round(S * 100.0) / 100.0;
            Console.WriteLine("Радиус =" + R);
            Console.WriteLine("Площадь круга =" + S);

        }

    }

    public class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Вычисляем площадь квадрата, введите сторону квадрата");

            Square test = new Square();
            string A = Square.a;


            Console.WriteLine(A);

         
            Console.WriteLine("Вычисляем площадь круга, введите радиус");

            Circle test1 = new Circle();
        }
    }
}


            //test.GetSide();
            //   Console.WriteLine("Сторона" + test.GetSide());


            //Console.WriteLine(test.GetSide());
            /*  double d;
              double side;
              string a;

              Console.WriteLine("Вычисляем площадь квадрата, введите сторону квадрата");

              Square test = new Square();


              for (int i = 0; i <= 1; i++)
              {
                  try
                  {

                      test.GetSquare();



                      break;
                  }
                  catch
                  {
                      if (i <= 1)
                          Console.WriteLine("Повторите попытку, система принимает только значения типа int и double, например: 5,25 или 10");
                      if (i == 1)
                      {

                          test.GetRandomSquare();

                      }
                  }

              }

            /*  Console.WriteLine("Вычисляем площадь круга, введите радиус");


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
              Console.WriteLine("Определяем поместится ли круг в квадрат:");

              d = test.GetDiameter();
              Console.WriteLine("Диаметр:" + d);

              side = test.GetSide();
              Console.WriteLine("Сторона квадрата:" + side);


              /*  if (d < side)
                {

                }*/

            //Circle test1 = new Circle();
            //Square test2 = new Square();
            // test1.GetDiameter();
            //Console.WriteLine(test.GetDiameter());




