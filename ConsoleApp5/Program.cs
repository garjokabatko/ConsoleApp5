using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Въведете векторите, всеки на нов ред, разделени с интервал. За край на въвеждането, натиснете Enter на празен ред:");
        string input;
        double shortestLength = double.MaxValue;

        while ((input = Console.ReadLine()) != string.Empty)
        {
            double[] vector = input.Split(' ').Select(double.Parse).ToArray();
            double length = Math.Sqrt(vector.Select(x => x * x).Sum());
            if (length < shortestLength)
            {
                shortestLength = length;
            }
        }

        Console.WriteLine($"Дължината на най-късият вектор е: {shortestLength}");
    }
}
