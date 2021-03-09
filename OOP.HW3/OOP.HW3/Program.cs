using System;
using System.Linq;

namespace OOP.HW3
{

    class Program
    {

       static int Min { get; set; }
       static int Max { get; set; }

       static void SetMin()
        {
            while (true)
            {
                Console.WriteLine("Введите нижнюю границу диапазона");

                string input = Console.ReadLine();
                int min;
                if (int.TryParse(input, out min) && min >= 0)
                {
                    Min = min;
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите попытку");
                }
            }

        }

       static void SetMax()
        {
            while (true)
            {
                Console.WriteLine("Введите верхнюю границу диапазона");

                string input = Console.ReadLine();
                int max;
                if (int.TryParse(input, out max) && max > 0)
                {
                    Max = max;
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите попытку");
                }
            }
        }

        static void Main(string[] args)
        {
           
            SetMin();
            SetMax();

            while (true)
            {
                if (Max - Min <= 10)
                {
                    Console.WriteLine("Заданный диапазон должен вмещать в себе больше 10ти значений, попробуйте еще раз");
                    SetMin();
                    SetMax();
                }
                else
                {
                    break;
                }
            }

            int[] arr = Enumerable.Range(Min, (Max - Min)+1).ToArray();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 != 0)
                {
                    sum = sum + arr[i];
                }
            }

            if (sum == 0)
            {
                Console.WriteLine("Чисел, делящихся на 3 и не делящихся на 5 в диапазоне нет");
            }
            
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine("Cумма чисел, которые делятся на 3 и не делятся на 5 = "+ sum);
            Console.ReadLine();


        }      
      
    }
}
