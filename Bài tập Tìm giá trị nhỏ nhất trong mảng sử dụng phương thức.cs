using System;
class hello {
public static int MinValue ( int [] arr )
{
    int min = arr[0];
    int index = 0 ;

    for (int i = 1 ; i < arr.Length ; i ++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}
public static void Main(string[]args)
{
    int []arr = { 5,2,3,9,8,6};
    int index = MinValue(arr);
    Console.WriteLine("The smallest element in the array is: " + arr[index]);
}
}