using System;
namespace Chuyendoitiente{
    class chuyendoitiente{
        static void Main (string[]args){
            float VNĐ;
            float USD;
            
            Console.Write("Nhập VNĐ :");
            USD = float.Parse(Console.ReadLine());
            
            VNĐ = USD * 23000;
            Console.WriteLine("Số tiền sau khi chuyển đổi :" + VNĐ + " VNĐ");
        }
    }
}