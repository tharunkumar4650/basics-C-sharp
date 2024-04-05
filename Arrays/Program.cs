using System;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;
namespace Arrays;
class Program
{
    public static void Main(string[] args)
    {
        const int n=5;
        string[]array1=new string[n]{"Mani","Ganesh","Venkat","Suresh","Venkat"};
        bool var=true;
        for(int i=0;i<5;i++)
        {
            Console.WriteLine(array1[i]);

        }
        string name=Console.ReadLine();
        foreach(string word in array1){
        if(word == name){
             var=false;
            Console.WriteLine("The name is present in array");
            
            
        }}
        if(var){
            Console.WriteLine("The name is not present in array");
            
        }
        


    }
}
