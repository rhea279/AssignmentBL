using System;
class Handshakes{
	static void Main(string[] args){
		Console.Write("Enter the number of student:");
		int student = Int32.Parse(Console.ReadLine());
		int handshakes = HandshakesPossible(student);
		Console.Write($"The number of possible handshakes is {handshakes}");
		
	}
	//Calculate the number of Handshakes possible
	static int HandshakesPossible(int student){
		int handshakes = (student * (student - 1)) / 2 ;
		return handshakes;
	}
}