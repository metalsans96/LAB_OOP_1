//using System;

//class Program
//{
//    static double CalculateY(double x, double z)
//    {
//        double numerator = Math.Abs(Math.Pow(x, 3) - Math.Pow(z, 3));
//        double denominator = Math.Sqrt(Math.Pow(x, 2) - 9);

//        if (denominator == 0)
//        {
//            throw new DivideByZeroException("Denominator cannot be zero.");
//        }

//        double y = numerator / denominator;
//        return y;
        
//    }

//    static void Main()
//    {
//        double x, z;
//        // Задайте значення x і z, для яких потрібно обчислити y
//        Console.Write("Введiть значення x: ");
//        x = Convert.ToDouble(Console.ReadLine()); // Змiніть це значення на бажане
//        Console.Write("Введiть значення z: ");
//        z = Convert.ToDouble(Console.ReadLine());  // Змiніть це значення на бажане

//        try
//        {
//            double result = CalculateY(x, z);
//            Console.WriteLine($"Значення y для x = {x} i z = {z} дорiвнює {result}");
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine($"Помилка: {ex.Message}");
//        }
//    }
//}

using System;

//class Program
//{
//    static void Main()
//    {
//        // Введіть обмеження для послідовності
//        int n = 100; // Змініть це значення на бажане

//        Console.WriteLine($"Члени послiдовностi, що при дiленнi на 7 дають залишок 1, 2 або 5 для n = {n}:");

//        for (int i = 1; i <= n; i++)
//        {
//            if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5)
//            {
//                Console.Write($"{i} ");
//            }
//        }

//        Console.WriteLine(); // Друк пустого рядка для читабельності
//    }
//}

using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number <= 3)
        {
            return true;
        }

        if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Введiть натуральне число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Близнюки-простi числа серед чисел вiд 2 до {n}:");
        for (int i = 2; i <= n - 2; i++)
        {
            if (IsPrime(i) && IsPrime(i + 2))
            {
                Console.WriteLine($"{i} i {i + 2}");
            }
        }
    }
}