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
		//DetermineIfSpeeding(Int32.Parse(myCar.currSpeed));
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
		/*
		public void DetermineIfSpeeding(int speed)
		{
			// bool speeding = false;
			if (speed > 60)
			{
				// speeding = true;
				Console.WriteLine("You are speeding");
			}
			//else { speeding = true; }
		}
		*/

		
		 public Car (string name, int c)
		{
			petName = name + " with constructor";
			Console.WriteLine("Length of name: "+petName.Length.ToString());
			currSpeed = c;
			// if statement works with both c and currSpeed 
			if (currSpeed > 60) Console.WriteLine("you're above the speed limit");
		}
		
		
	}
}
