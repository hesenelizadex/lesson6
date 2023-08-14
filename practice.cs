// 1 ci mesele
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = new int[3];
          numbers[0]=10;
          numbers[1]=11;
          numbers[2]=12;
        }
    }
}
// 2 ci mesele
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = {10,11,12};
          for (int i=0;i<3;i++)
          {
            Console.WriteLine(numbers[i])
          
          }
        }
    }
}
// 3 cü mesele
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = {10,11,12};
          for (int i=0;i<=numbers.Length;i++)
          {
            Console.WriteLine(numbers[i])
          
          }
        }
    }
}
// 4 cü mesele
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = {10,11,12};
          foreach ( var number in numbers)
          {
            Console.WriteLine(number)
          
          }
        }
    }
}

