using System;
using System.Dynamic;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
class Hello{
	public static void Main(string[]args){
		Console.Clear();
		int height = 15;
		int width = 15;
        int x = 10 ;
		int y = 10 ;
		int score = 0 ;
		
		
		
		int a;
        Random rd1 = new Random();
        a = rd1.Next(1, 24);
		int b;
		Random rd2 = new Random();
        b = rd2.Next(1, 15);
		

		Console.BackgroundColor = ConsoleColor.Red;
		for(int i = 0;i < (height+10);i++){
			Console.SetCursorPosition(i,height-15);
			Console.Write("■");
		}
		for(int i = 0 ; i < (width+10); i++){
			Console.SetCursorPosition(i,width);
			Console.Write("■");
		}
		for(int i = 0 ; i < (width+1); i++){
			Console.SetCursorPosition(0,i);
			Console.Write("■");
		}	
		for(int i = 0 ; i < (height+1); i++){
			Console.SetCursorPosition(width+10,i);
			Console.Write("■");		
	    }
		
		Console.BackgroundColor = ConsoleColor.Black;
		Console.SetCursorPosition(a,b);
		Console.Write("O");
       



		Console.BackgroundColor = ConsoleColor.Green;
		Console.SetCursorPosition(x,y);
		Console.Write("■");


		while(true){
			
	if(Console.KeyAvailable){		
		ConsoleKeyInfo keyInfo = Console.ReadKey();	
		Console.BackgroundColor = ConsoleColor.Green;
		if (keyInfo.Key == ConsoleKey.UpArrow){
				Console.SetCursorPosition(x,y-1);
				Console.Write("■");
				y--;
				Console.BackgroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(x,y+1);
				Console.Write(" ");		
		}
		else if (keyInfo.Key == ConsoleKey.DownArrow){
			    Console.SetCursorPosition(x,y+1);
				Console.Write("■");
				y++;
				Console.BackgroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(x,y-1);
				Console.Write(" ");		
		}
		else if (keyInfo.Key == ConsoleKey.LeftArrow){
			    Console.SetCursorPosition(x-1,y);
				Console.Write("■");
				x--;
				Console.BackgroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(x+1,y);
				Console.Write(" ");	
				
		}
		else if (keyInfo.Key == ConsoleKey.RightArrow){
			    Console.SetCursorPosition(x+1,y);
				Console.Write("■");
				x++;
				Console.BackgroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(x-1,y);
				Console.Write(" ");	
		}
		if( x == a && y == b )
		{
			Random rd3 = new Random();
            a = rd3.Next(1, 24);

			Random rd4 = new Random();
            b = rd4.Next(1, 15);
			
			
			Console.BackgroundColor = ConsoleColor.Black;
		    Console.SetCursorPosition(a,b);
		    Console.Write("O");

			score += 1;
		}		
	    if (x == 0 || y == 0 || x == 25 || y == 15 )
		{
			 Console.Write("Game Over");
			 break;
		}
		Console.SetCursorPosition(0,17);
		Console.Write($"score:{score}");		
		Console.SetCursorPosition(x+1,y);
	}
		Console.ResetColor();
	}
	}  
}
	
	
	

