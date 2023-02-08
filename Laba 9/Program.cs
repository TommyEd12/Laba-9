using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    class Program
    {
        static void demo(string[] args)
        {
            try
            {
                TriangleArray arr1 = new TriangleArray();
                int len = Interactions.ReadInt("Введите длину массива");
                if (len == 0)
                    throw new Exception("Введен пустой массив");
                int choosefeature = Interactions.ReadInt("Выберите функцию 0 - Генерация случайных элементов 1 - Ввод элемнетов");
                if (choosefeature == 0)
                {
                    arr1 = new TriangleArray(len);
                    arr1.Show();
                }
                if (choosefeature == 1)
                {
                    arr1 = new TriangleArray(len, choosefeature);
                }
                arr1[0].Show();
                Console.WriteLine(arr1[0].CountArea(arr1[0]));
                Console.WriteLine($"Номер элемента с минимальной площадью - {ShowMinAreaIndex(arr1) + 1}");
                Console.WriteLine($"Объектов создано - {TriangleArray.countarrayel - 1}");

                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Неправильно задан индекс");
            }


        }
        static void Main(string[] args)
        {
            try
            {
                demo(args);
                Triangle t1 = new Triangle(3, 4, 5);
                Triangle t2 = new Triangle(10, 15, 8);
                if (!t1.IsTriangle || !t2.IsTriangle)
                    throw new Exception("Неверно указаны стороны треугольника");
                t1++;
                t1.Show();
                t1.CountArea(t1);
                t2--;
                t2.Show();
                Triangle.CountArea1(t2);
                double q = (double)t2;
                bool m = t2;
                Console.WriteLine(m);
                Console.WriteLine(q);
                if (t2 >= t1)
                    Console.WriteLine("t2 >= t1");
                double s = Triangle.CountArea1(t1);
                Console.WriteLine($"Объетов создано - {Triangle.count}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int ShowMinAreaIndex(TriangleArray arr)
        {
            double min = 100000000;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CountArea(arr[i]) < min)
                {
                    min = arr[i].CountArea(arr[i]);
                    index = i;
                }
            }
            return index;
        }
    }
}

