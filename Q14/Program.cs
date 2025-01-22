using System;
class ConvertDistance{
	static void Main(string[] args){
		Console.Write("Enter the distance in feet:");
		int feet = Int32.Parse(Console.ReadLine());
		
		int yard = DistanceInYard(feet);
		int mile = DistanceInMile(feet);
		
		Console.Write($" Your Distance in feet is {feet} while in yard is {yard} and miles is {mile}");
	}
	//Convert distance to yard
	static int DistanceInYard(int feet){
		int yard = feet*3;
		return yard;
	}
	//Convert distance to mile
	static int DistanceInMile(int feet){
		int mile = feet*3*1760;
		return mile;
	}
}