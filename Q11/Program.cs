using System;
class Calculator{
	static void Main(string[] args){
		Console.Write("Enter first input:");
		int n1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter second input:");
		int n2 = Int32.Parse(Console.ReadLine());
		
		int add = Addition(n1,n2);
		int sub = Substraction(n1,n2);
		int mul = Multiplication(n1,n2);
		int div = Division(n1,n2);
		Console.Write($"The addition, subtraction, multiplication and division value of 2 numbers {n1} and {n2} is {add}, {sub}, {mul}, and {div}");
	}
	//Perform Addition
	public static int Addition(int n1, int n2){
		int add = n1+n2;
		return add;
	}
	//Perform Substraction
	public static int Substraction(int n1, int n2){
		int sub = n1-n2;
		return sub;
	}
	//Perform Multiplication
	public static int Multiplication(int n1, int n2){
		int mul = n1*n2;
		return mul;
	}
	//Perform Division
	public static int Division(int n1, int n2){
		int div = n1/n2;
		return div;
	}
}