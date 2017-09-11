using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	// automatic name 
class Program
{
	static void Main(string[] args)
	{
		// without explicit constructor
		// this would use string variables for both variables
		/*
		Console.WriteLine("Write your car's name");
		Car myCar = new Car();
		myCar.petName = Console.ReadLine();

		Console.WriteLine("Write your car's speed");
		myCar.currSpeed = Console.ReadLine();
		*/
		
		// WITH explicit constructor
		
		Console.WriteLine("Write your car's name");
		string inputCarName=Console.ReadLine();
		Console.WriteLine("Write your car's speed");
		int inputCarSpeed = Int32.Parse(Console.ReadLine());
		Car myCar = new Car( inputCarName, inputCarSpeed );
		

		// Console.WriteLine("Hello");
		Console.WriteLine("Name: {0}. Speed: {1}", myCar.petName, myCar.currSpeed);
		Console.ReadKey();
	}

	public class Car
	{
		public string petName;
		public int currSpeed;
		
		 public Car (string name, int c)
		{
			this.petName = name + " with constructor";
			this.currSpeed = c + 12; 
		}
		
	}
}
