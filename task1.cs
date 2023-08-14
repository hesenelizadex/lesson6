using System;
namespace ArraySumExample
{
    class Program
    {
        static int ArrayCem(int[] arr)
        {
            int sum;
            sum=0;
            foreach (int num in arr)
            {
                sum = sum + num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Massivdeki elementlerin sayini daxil edin: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = ArrayCem(array);
            Console.WriteLine($"Massivdeki elementlerin cemi: {sum}");
        }
    }
}
