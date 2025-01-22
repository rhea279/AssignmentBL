using System;
class EarthVolume{
	static void Main(string[] args){
		int radius = 6378;//Earth's radius
		double volumeKms = (4.0/3)*Math.PI*Math.Pow(radius,3);//Volume in cubic kms
		double conversionFactor = Math.Pow(0.621371, 3); // 1 kilometer = 0.621371 miles (cubed)
        double volumeMiles = volumeKms * conversionFactor; // Volume in cubic miles
		
		Console.Write($"The volume of earth in cubic kilometers is {volumeKms} and cubic miles is {volumeMiles}");
	}
	
}