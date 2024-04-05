using System;
using System.ComponentModel.DataAnnotations;
namespace DowhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        string word;

        do
        {
            Console.Write("enter the no:");
            int num=int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.Write("enter yes or no:");
            word=Console.ReadLine();
            if(word!="yes" && word!="no"){
                Console.WriteLine("provided input is wrong and the valid key ");
                word=Console.ReadLine();
            }
        }while(word=="yes");
    }
}
