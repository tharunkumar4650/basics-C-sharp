using System;
namespace Duplicate;
class Program{
    public static void Main(string[] args)
    {
        string n=Console.ReadLine();
        string a=string.Empty;
         for(int i=0;i<n.Length;i++){
            if(!a.Contains(n[i])){
                a=a+n[i];
            }
            
         }
         Console.WriteLine(a);
            
        
    }

}
