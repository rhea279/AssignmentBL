using System;
class PenDistribution{
	static void Main(string[] args){
		int pens = 14;
		int students = 3;
		
		int perStudent = pens/students;
		int remaining = pens%students;
		Console.Write($"The Pen Per Student is {perStudent} and the remaining pen not distributed is {remaining}");
	}
}