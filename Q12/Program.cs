using System;
class AreaTriangle{
	static void Main(string[] args){
		Console.Write("Enter base of triangle in cms:");
		int baseT = Int32.Parse(Console.ReadLine());
		Console.Write("Enter height of triangle in cms:");
		int ht = Int32.Parse(Console.ReadLine());
		
		double areaCm = AreaCms(baseT,ht);
		double areaInch = AreaInch(baseT,ht);
		
		Console.Write($"Area of Triangle in sq.cm is {areaCm} and in sq.inches is {areaInch:F2}");
		
	}
	//Calculate Area of Triangle in sq.cm 
	public static double AreaCms(int baseT, int ht){
		double areaCm = 0.5*baseT*ht;
		return areaCm;
	}
	////Calculate Area of Triangle in sq.inches 
	public static double AreaInch(int baseT,int ht){
		double areaInch = 0.5*baseT*ht/2.54;
		return areaInch;
	}
}