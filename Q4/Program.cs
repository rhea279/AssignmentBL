using System;
class Profitloss{
	static void Main(string[] args){
		//Cost Price
		int cp = 129;
		//Selling Price
		int sp = 191;
		
		//Calculate profit & profit pecentage
		int profit = sp - cp;
		double profitPer = ((profit/(double)cp)*100.0);
		Console.WriteLine($"The Cost Price is INR {cp} and Selling Price is INR {sp}");
		Console.WriteLine($"The Profit is INR {profit} and the Profit Percentage is {profitPer:F2}");
	}
}