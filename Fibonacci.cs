using System;

public class Fibonacci
{
	public static void Main(string[] args)
	{
		 Console.WriteLine("-------Fibonacci Series ---------");
		 Console.WriteLine("Enter the number of digits you want to display");
		 int number = int.Parse(Console.ReadLine());              
		  int preNum = 0;
		  int nextNum = 1;
		 
		  for (int i = 1; i <= number; ++i)
		  {
		  Console.Write("{0}" + (i < number ? ", " : ""), preNum);
		  int sum = preNum + nextNum;
		  preNum = nextNum;
		  nextNum = sum;
		  }
	}
}