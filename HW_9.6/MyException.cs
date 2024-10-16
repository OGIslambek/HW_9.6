using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6
{
    static class MyException
    {
        internal static void MyEx()
        {
            Exception[] exceptions = new Exception[5]
            {
            new NewException("Некорректный ввод"),
            new DivideByZeroException("Знаменатель в операции деления или целого числа равен нулю."),
            new ArgumentNullException("Аргумент, передаваемый в метод — null."),
            new ArgumentOutOfRangeException("Аргумент находится за пределами диапазона допустимых значений."),
            new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции.")
            };

        }
    }
}
