using System;
class TotalPrice{
	static void Main(string[] args){
		Console.Write("Enter the unit price of item:");
		int unitPrice = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the quantity of item:");
		int quantity = Int32.Parse(Console.ReadLine());
		
		int purchaseprice = PurchasePrice(unitPrice,quantity);
		Console.WriteLine($"The total purchase price is INR {purchaseprice} if the quantity {quantity} and unit price is INR {unitPrice}");
	}
	//Calculate the total purchase price
	static int PurchasePrice(int unitPrice, int quantity){
		int purchaseprice = unitPrice*quantity;
		return purchaseprice;
	}
}