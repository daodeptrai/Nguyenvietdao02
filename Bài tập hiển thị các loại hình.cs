using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Hienthicacloaihinh{
    class hienthicacloaihinh{
        static void Main(string[]args){
            
            int height;
            int width;

            Console.WriteLine(" Menu :");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your menu:");
            int menu = Int32.Parse(Console.ReadLine());
            

        if(menu <= 1){
            for( height = 0 ; height <=2; height++){
                Console.WriteLine(" * ");
                for( width = 0 ; width <=5 ;width++ ){
                    Console.Write(" * ");
                }
            }
            Console.Write(" * ");
        }
        else if(menu <=2){
            for( height = 0 ; height <=5; height++){
                Console.WriteLine(" * ");
                for( width = 0 ; width <= height ;width++ ){
                    Console.Write(" * ");
                }
            }
            Console.Write(" * ");
        }
        else if(menu <=3){
            for( width = 7 ; width >=0; width--){
                Console.WriteLine(" * ");
                for( height = 1 ; height <= width ;height++ ){
                    Console.Write(" * ");
                }
            }
            Console.Write(" * ");
        }
    }
}   
}
   