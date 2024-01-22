using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_455_Assignment_1 {
	public class MyFunctions {
		public static void PrintMenu () {
			// want to make/print the menu with this function
			//menu of other options given

			Console.WriteLine("1: Random number 1-10.\n");
			Console.WriteLine("2: Today's date.\n");
			Console.WriteLine("3: List of dinosaurs.\n");
			Console.WriteLine("4: String class methods.\n");
		}
		public static int RandomNum () {
			// make random number 1-10 and return it

			return (RandomNum() % 10) + 1;
		}
	}
	internal class Program {
		static void Main (string[] args) {
			MyFunctions.PrintMenu(); // print the menu

			var locum = Console.ReadLine();
			int choice = int.Parse(locum);


			Console.WriteLine($"{MyFunctions.RandomNum()}\n"); // print the random number
		}
	}
}
