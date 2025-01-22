import java.util.Scanner;

class StudentFee {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the student fee: ");
        double fee = input.nextDouble();
        
        System.out.print("Enter the discount percentage: ");
        double discountPercent = input.nextDouble();
        
        // Calculate discount and new fee
        double discount = fee * (discountPercent / 100);
        double newFee = fee - discount;
    
        System.out.println("The discount amount is INR " + discount + " and final discounted fee is INR " + newFee);
    }
}
