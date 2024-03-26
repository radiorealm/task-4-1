using System;

namespace task_4_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input array capacity or 0 if default");
            int n = int.Parse(Console.ReadLine());

            OneDim<int> custom_array = (n == 0) ? new() : new(n);

            Console.WriteLine("Input array size");
            int _n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input elements one by one");
            for (int i = 0; i < _n; i++)
            {
                custom_array.Add(int.Parse(Console.ReadLine()));
            }
            custom_array.Print();

            Console.WriteLine("First even element");
            Console.WriteLine(custom_array.Find(t => t % 2 == 0));

            Console.WriteLine("All elements > 10");
            custom_array.Print(custom_array.FindAll(t => t > 10));

            Console.WriteLine("All double elements");
            custom_array.Print(custom_array.FindAll<double>());

            Console.WriteLine("Input an element you want to check for existence");
            Console.WriteLine(custom_array.Check(int.Parse(Console.ReadLine())));

            Console.WriteLine("Input an element you want to remove");
            custom_array.Remove(int.Parse(Console.ReadLine()));
            custom_array.Print();
        }
    }
}
