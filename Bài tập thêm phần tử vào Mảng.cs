using System;
using System.Security.Cryptography.X509Certificates;
class Hello 
{
    static void Main (string[]args)
    {
        int[] arr1 = new int[10];
        int i, n, p = 0, phan_tu_moi;
        Console.Write("Nhap kich co mang: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("Phan tu - {0}: ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Nhap gia tri phan tu can chen: ");
        phan_tu_moi = Convert.ToInt32(Console.ReadLine());
        Console.Write("In mang truoc khi chen:\n ");
        for (i = 0; i < n; i++)
            Console.Write("{0} ", arr1[i]);
        for (i = 0; i < n; i++)
            if (phan_tu_moi < arr1[i] && i <= arr1.Length)
            {
                p = i;
                break;
            }
        for (i = n; i >= p; i--)
            arr1[i] = arr1[i - 1];
        arr1[p] = phan_tu_moi;

        Console.Write("\n\nSau khi chen, mang co cac phan tu:\n ");
        for (i = 0; i <= n; i++)
            Console.Write("{0} ", arr1[i]);
        Console.Write("\n");    

        Console.ReadKey();
    }
}