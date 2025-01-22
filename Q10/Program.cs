using System;
class ConvertHeight{
	static void Main(string[] args){
		Console.WriteLine("Enter your height in cms:");
		double cms = Double.Parse(Console.ReadLine());
		
		double feet = CmsToFeet(cms);
        double inches = CmsToInches(cms);
        
        Console.WriteLine($"Your Height in cm is {cms}, in feet is {Math.Floor(feet)}, and inches is {Math.Round(inches % 12, 2)}");
	}
	//Convert cm to feet
	public static double CmsToFeet(double cms){
		double feet = (cms/30.48);
		return feet;
	}
	//Convert cm to inches
	public static double CmsToInches(double cms){
		double inches = (cms/2.54);
		return inches;
	}
}