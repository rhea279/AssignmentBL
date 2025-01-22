using System;
class SideSquare{
	static void Main(string[] args){
		Console.Write("Enter the Perimeter of Square:");
		double per = Double.Parse(Console.ReadLine());
		double side = SideOfSq(per);
		Console.Write($"The length of the side is {side:F2} whose perimeter is {per}");
	}
	static double SideOfSq(double per){
		double side = per/4;
		return side;
	}
}