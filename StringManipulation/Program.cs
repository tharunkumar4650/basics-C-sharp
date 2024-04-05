using System;
using System.Threading;
namespace StringManipulation;
class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Main String:");
       string word=Console.ReadLine();
       Console.Write("String to be searched:");
       string word1=Console.ReadLine();
       string[] word2=word.Split(word1);
       int Count=0;
       foreach( string i in word2)
       {
        Count++;
       }
       Console.WriteLine(Count-1);
       

    }

}
