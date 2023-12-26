using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _16Lesson
{
    //File15: Дан файл вещественных чисел. Найти сумму его элементов с четными номерами.
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "16les_file3.txt"; // Приклад імені файлу

            string[] lines = File.ReadAllLines(fileName); // Зчитуємо всі рядки з файлу

            int sum = 0;

            for (int i = 0; i < lines.Length; i += 2)
            {
                int number = int.Parse(lines[i]); // Перетворюємо рядок на веществене число

                sum += number; // Додаємо число до суми
            }

            Console.WriteLine("Сума елементiв з парними номерами: " + sum);

            Console.ReadLine();
        }
    }
}
