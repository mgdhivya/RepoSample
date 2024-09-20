using System;

class Review{

	//int a,b;
	static string name="Hello";

	const int Price_Salary=20000;
	

	public static void displayMessage(string sname){
		Console.WriteLine($"{sname}");
		Console.WriteLine("im static variable from static method ",$"{name}");
	}
	

	int showProduct(int a,int b){

		int c=a*b;
		Console.WriteLine(c);

		displayMessage("Hi im static method from non static method");
		
		Console.WriteLine(name);

		return c;
		
		
	}

	
	static void Main(){
		
		Review obj=new Review();
		
		obj.showProduct(2,4);

		Console.WriteLine(name);
		displayMessage("Welocme to Product of two numbers");
		Console.WriteLine(Price_Salary);

		
	}



}