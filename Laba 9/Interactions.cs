using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    class Interactions
    {
        public static int ReadInt(string message) // Чтение целого числа с клавиатуры
        {
            Console.WriteLine(message);
            int number;
            bool isConvert;
            do
            {
                isConvert = int.TryParse(Console.ReadLine(), out number);
                if (!isConvert)
                    Console.WriteLine("Введите целое число");
            } while (!isConvert);
            return number;
        }
        public static double ReadDouble(string message) // Чтение целого числа с клавиатуры
        {
            Console.WriteLine(message);
            double number;
            bool isConvert;
            do
            {
                isConvert = double.TryParse(Console.ReadLine(), out number);
                if (!isConvert)
                    Console.WriteLine("Введите число");
            } while (!isConvert);
            return number;
        }

    }
}
