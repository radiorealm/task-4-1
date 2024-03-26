using System;

namespace task_4_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            OneDim<int> custom_array = new(n);

            for (int i = 0; i < n+1; i++)
            {
                custom_array.Add(int.Parse(Console.ReadLine()));
            }
            custom_array.Print();

            custom_array.Remove(custom_array.Find(t => t % 2 == 0));
            custom_array.Print();

            custom_array.Print(custom_array.FindAll(t => t > 10));
            custom_array.Print(custom_array.FindAll<bool>());

            Console.WriteLine(custom_array.Check(int.Parse(Console.ReadLine())));
        }
    }
}
