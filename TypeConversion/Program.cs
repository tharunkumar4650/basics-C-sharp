using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Trainee Details Are:");
        Console.Write("Name:");
        string b=Console.ReadLine();
         Console.Write("Age:");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Mobile:");
        long d = long.Parse(Console.ReadLine());
           Console.Write("Marks1:");
        int e=int.Parse(Console.ReadLine());
         Console.Write("Marks2:");
         int f=int.Parse(Console.ReadLine());
          Console.Write("Marks3:");
          int g=int.Parse(Console.ReadLine());
        Console.Write("Total:");
        Console.WriteLine(e+f+g);
        Console.Write("Average:");
        Console.WriteLine((e+f+g)/3);
        Console.Write("Grade:");
        string h=Console.ReadLine();
        Console.Write("Mail id");
        string i=Console.ReadLine();


    }
}
