using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_455_Assignment_1 {
	class MyFunctions {
		public static void PrintMenu () {
			// want to make/print the menu with this function
			// menu of other options given

			Console.WriteLine("1: Random number 1-10.\n");
			Console.WriteLine("2: Today's date.\n");
			Console.WriteLine("3: List of dinosaurs.\n");
			Console.WriteLine("4: String class methods.\n");

			var locum = Console.ReadLine();
			int choice = int.Parse(locum);

			DoMenu(choice);
		}
		private static int RandomNum (int max) {
			// make random number 1-10 and return it
			// mostly for practice and organization purposes

			Random rand = new Random();

			return rand.Next(max) + 1;
		}
		private static void PrintDate () {
			// print today's date in MM-DD-YYYY format
			// this is my preferred method of printing the date

			Console.WriteLine($"{DateTime.Now.ToString("MM-dd-yyyy")}");
		}
		private static void DinoLister () {
			Console.WriteLine("Please give me at least 10 Dinosaur names. Write <done> to finish:\n");

			// create list, temporary string, and counter for the user
			List<string> dinos = new List<string>();
			int counter = 1;
			string locum = "";

			// thoroughness for the people -_-
			while (locum != "done" && locum != "Done" && locum != "<done>" && locum != "<Done>") {
				Console.WriteLine($"{counter}: ");
				locum = Console.ReadLine();
				dinos.Add(locum);
				counter++;
			}
			Console.WriteLine("\n");

			dinos.Sort();

			// call the random number method
			// repurpose the counter int, make sure the index is correct
			counter = RandomNum(dinos.Count) - 1;
			Console.WriteLine($"{dinos[counter]}\n");
		}
		private static void ClassFun() {

		}
		public static void DoMenu (int choice) {
			switch (choice) {
				case 1: // print the random number
					Console.WriteLine($"{RandomNum(10)}\n");
					Console.ReadLine();
					break;
				case 2: // today's date
					PrintDate();
					Console.ReadLine();
					break;
				case 3: // dinosaur list
					DinoLister();
					Console.ReadLine();
					break;
				case 4: // string class
					ClassFun();
					Console.ReadLine();
					break;
				default: // if the choice was not valid
					Console.WriteLine("Invalid choice.\n");
					PrintMenu(); 
					// this could potentially lead down a rabbit hole of returns
					// however, since there is nothing after to process, this should be fine
					break;
			}
		}
	}
	internal class Program {
		static void Main (string[] args) {
			MyFunctions.PrintMenu(); // print the menu
		}
	}
}
