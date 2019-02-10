using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            int sum = 0;
            int maxValue = 0;

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 100);

                list.Add(randomNumber);

                if (i % 2 == 0)
                {
                    sum += randomNumber;
                }
                if (randomNumber > list[maxValue])
                {
                    maxValue = i;
                }
            }

           



            list.Sort();
            list.Distinct();
        
            int secondMaxValue = list[0];
          secondMaxValue =  list[list.LastIndexOf(list.Last())-1];
             foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов на четных позициях: {sum}");

            Console.WriteLine($"Второе максимальное чилсо: {secondMaxValue}");

            Console.ReadLine();

        }
    }
}
