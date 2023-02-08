using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    class TriangleArray
    {
        Triangle[] arr = new Triangle[0];
        static Random rnd = new Random();
        public static int countarrayel = 0;
        public int Length
        {
            get => arr.Length;
        }
        public TriangleArray()
        {
            arr = new Triangle[1];
            arr[0] = new Triangle(3, 4, 5);
            countarrayel++;
        }
        public TriangleArray(int length)
        {
                arr = new Triangle[length];
                for (int i = 0; i < length; i++)
                {
                    Triangle tr = new Triangle();
                    while (!tr.IsTriangle)
                        tr = new Triangle(rnd.NextDouble() + rnd.Next(50), rnd.NextDouble() + rnd.Next(50), rnd.NextDouble() + rnd.Next(50));
                    arr[i] = tr;
                    countarrayel++;
                }
        }
        public TriangleArray(int length, int choosefeature)
        {
            arr = new Triangle[length];
            if (choosefeature == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    Triangle tr = new Triangle();
                    while (!tr.IsTriangle)
                    {
                        Console.WriteLine("Введите стороны треугольника");
                        tr = new Triangle(Interactions.ReadDouble("A = "), Interactions.ReadDouble("B ="), Interactions.ReadDouble("C ="));
                    }
                    arr[i] = tr;
                    countarrayel++;
                }
            }
            else
                Console.WriteLine("Выбрана неверная опция");
        }

        public void Show()
        {
            for (int i = 0; i < this.Length; i++)
                arr[i].Show();
        }
        public Triangle this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
            }
        }
    }
}
