using System;
using System.Transactions;
class Hello {
static void Main (string[]args)
{
    double min ;
    double max ;
    int i ;
    int j ;
    const int x = 3;
    double [,] matrix = new double[3,3] ;
    for( i = 0; i < x;i++)
    {
        for( j = 0; j < x;j++)
        {
            Console.Write("element - [{0},{1}] : " , i , j);
            matrix[i,j] = Convert.ToDouble(Console.ReadLine());
        }
    }
    max = matrix[0,0];
    min = matrix[0,0];

    for(i = 0 ; i < x ; i++)
    {
        for(j = 0 ; j < x ; j++)
        {
            if(matrix[i,j] > max)
            {
                max = matrix[i,j];  
            }
            if(matrix[i,j] < min)
            {
                min = matrix[i,j];
            }
        }
    }
    foreach (var k in matrix)
    {
        Console.Write(k + "  ");
    }
    Console.WriteLine(" ");

    Console.WriteLine("Max value:" + max);
    Console.WriteLine("Min value:" + min);
    Console.ReadKey();
}
}