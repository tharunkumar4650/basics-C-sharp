using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                 string a=Console.ReadLine();
                string b=Console.ReadLine();
                char[] c=a.ToLower().ToCharArray();
                 char[] d=b.ToLower().ToCharArray();
                 Array.Sort(c);
                 Array.Sort(d);  
                 string e=new string(c);
                 string f=new string(d);   
                 if(a==b){
                    Console.WriteLine("Anagrams");
                 } 
                 else{
                    Console.WriteLine("Not Anagrams");
                 }      
            }
        }