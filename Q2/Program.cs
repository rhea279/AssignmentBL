using System;
class AverageMarks{
	static void Main(string[] args){
		int phy = 94;
		int maths = 94;
		int chem = 96;
		
		double avg = ((phy+maths+chem)/300.0)*100;
		Console.Write($"Sam's average percent mark in PCM is {avg:F2}%");
	}
}
	