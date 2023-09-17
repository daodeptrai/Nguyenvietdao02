using System;
using System.Security.Cryptography;
class Hello 
{
    static void Main(string[]args)
    {
        int x;
        int i;
        int j;
        double z = 0;
        Console.Write("Nhap kich thuoc mang:");
         x = Convert.ToInt32(Console.ReadLine());
        double [,] matrix  = new double[x,x];


        for(i = 0; i < x;i++)
        {
            for(j = 0; j < x;j++)
            {       
            Console.Write("Phan Tu - [{0},{1}] :" , i , j );
            matrix[i,j] = Convert.ToDouble(Console.ReadLine());
            }
        }
       for(i=0 ; i < x; i++)
       {
        if(i <= matrix.GetLength(1))
        {
            Console.WriteLine(" ");
        }
        for(j=0 ; j < x; j++)
        {
            Console.Write(matrix[i,j] + "  ");
        }
        Console.WriteLine(" ");
       }

        for(i = 0; i < x;i++)
        {
            for(j = 0; j < x;j++)
            {
            if(i==j)
            {           
                z = z + matrix[i,j] ;
            }
            }
        }
      Console.WriteLine(" tong duong cheo chinh(1) = " + z);

           
    }
}