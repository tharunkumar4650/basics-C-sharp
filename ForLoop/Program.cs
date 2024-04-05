using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i,a=0;
        int num1=int.Parse(Console.ReadLine());
        int num2=int.Parse(Console.ReadLine());
        for(i=num1;i<=num2;i++)
        {
            a=i*i + a;
        }
        Console.WriteLine(a);

    }
}