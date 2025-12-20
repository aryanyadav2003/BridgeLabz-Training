using System;
class Discount2{
    static void Main(){
	  double fee=Convert.ToDouble(Console.ReadLine());
	  double discountPercent=Convert.ToDouble(Console.ReadLine());
	  double discount=(discountPercent*fee)/100;
	  double finalFee=fee-discount;
	  Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
}
}