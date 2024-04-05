using System;
using System.Runtime.InteropServices;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i=0,n=25,a;
        while(i<=n)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);

            }
            i++;

        }
        Console.WriteLine("enter the no:");
        bool isValid = int.TryParse(Console.ReadLine(),out int output);
        while(!isValid)
        {
             isValid = int.TryParse(Console.ReadLine(),out  output);
            Console.WriteLine("INVALID");
        }
        
    }
}

