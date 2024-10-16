using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6
{
    internal class MyException
    {
        Exception[] exceptions = new Exception[5]
        {
            new NewException(""),
            new DivideByZeroException("Знаменатель в операции деления или целого числа равен нулю."),
            new ArgumentNullException("Аргумент, передаваемый в метод — null."),
            new ArgumentOutOfRangeException("Аргумент находится за пределами диапазона допустимых значений."),
            new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции.")
    };

    }
}
