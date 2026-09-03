using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());

        for (int i = 1; i <= X; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
