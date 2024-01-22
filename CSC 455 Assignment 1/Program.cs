using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_455_Assignment_1 {
	public class MyFunctions {
		public static void PrintMenu () {
			// want to make/print the menu with this function
			// menu of other options given

			Console.WriteLine("1: Random number 1-10.\n");
			Console.WriteLine("2: Today's date.\n");
			Console.WriteLine("3: List of dinosaurs.\n");
			Console.WriteLine("4: String class methods.\n");
		}
		public static int RandomNum (int max) {
			// make random number 1-10 and return it
			Random rand = new Random();

			return rand.Next(max) + 1;
		}
		public static void PrintDate() {
			// print today's date in MM-DD-YYYY format

			Console.WriteLine($"{DateTime.Now.ToString("MM-DD-YYYY")}");
		}
		public static void DoMenu (int choice) {
			switch (choice) {
				case 1: // print the random number
					Console.WriteLine($"{RandomNum(10)}\n");
					break;
				case 2: // today's date
					PrintDate();
					break;
				case 3: // dinosaur list

					break;
				case 4: // string class

					break;
				default: // if the choice was not valid
					Console.WriteLine("Invalid choice.\n");
					break;
			}
		}
	}
	internal class Program {
		static void Main (string[] args) {
			MyFunctions.PrintMenu(); // print the menu

			var locum = Console.ReadLine();
			int choice = int.Parse(locum);

			MyFunctions.DoMenu(choice);
		}
	}
}
