using System;
namespace Matrix;
class Program
{
    public static void Main(string[] args)
    {
        int rows1=int.Parse(Console.ReadLine());
        int cols1=int.Parse(Console.ReadLine());
         int rows2=int.Parse(Console.ReadLine());
          int cols2=int.Parse(Console.ReadLine());
         int[,] arr1=new int[rows1,cols1];
         int[,] arr2=new int[rows2,cols2];
         int[,] result=new int[rows1,cols2];
         for(int i=0;i<rows1;i++){
            for(int j=0;j<cols1;j++){
                arr1[i,j]=int.Parse(Console.ReadLine());
            }
         }
         for(int i=0;i<rows2;i++){
            for(int j=0;j<cols2;j++){
                arr2[i,j]=int.Parse(Console.ReadLine());
            }
         }
          for(int i=0;i<rows1;i++){
            for(int j=0;j<cols2;j++){
                for(int k=0;k<cols1;k++){
                    result[i,j]=result[i,j]+arr1[i,k]*arr2[k,j];

                }

            }
          }
           for(int i=0;i<rows1;i++){
            for(int j=0;j<cols2;j++){
                Console.Write(result[i,j]+"\t");
            }
            Console.WriteLine();
         }

    }
}