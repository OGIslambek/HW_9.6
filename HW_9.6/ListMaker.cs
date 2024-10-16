using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6
{
    internal class ListMaker
    {
        public static List<string> NewList()
        {
            List<string> lastNames = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите фамилию {i + 1}");
                lastNames.Add(Console.ReadLine());

                try
                {
                    foreach (char c in lastNames[i])
                    {

                    }
                }
                catch
                {
                    throw new NewException("Некорректный ввод фамилии");
                }
            }
            return lastNames;
        }
    }
}
