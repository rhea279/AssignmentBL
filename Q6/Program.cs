using System;
class UniFee{
	static void Main(string[] args){
		int fee = 125000;//College Fee charged
		int discountPer = 10;//Discount percent offered;
		
		//Calculate discount amount and new fee
		int discount = (int)(fee * (discountPer / 100.0)); 
        int newFee = fee - discount;
		Console.Write($"The discount amount is INR {discount} and final discounted fee is INR {newFee}");
	}
}