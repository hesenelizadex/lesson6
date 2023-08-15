using System;
class Program
{
    static void Main(string[] args)
    {
        string[] Array = { "Hesen", "Murad", "Akif", "Elman"};

        Console.Write("Massivdə axtardığınız stringi daxil edin: ");
        string inputString = Console.ReadLine();

        bool StringTap = StringYoxlama(Array, inputString);

        if (StringTap)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }

    static bool StringYoxlama(string[] array, string target)
    {
        foreach (string item in array)
        {
            if (item == target)
            {
                return true;
            }
        }
        return false;
    }
}
