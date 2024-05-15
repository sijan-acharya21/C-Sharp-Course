// When program is run it closes immendiately because it is not waiting for any input
Console.WriteLine("What is your age?");

// Console.ReadLine() is always written in as a string
// Console.ReadLine() is waiting at the console for the user to press Enter
Console.WriteLine("What is your first name?"); 

string firstName = Console.ReadLine();
Console.WriteLine("What is your last name?");
string lastName = Console.ReadLine();
Console.WriteLine($"Hello, {firstName} {lastName}");

// Parsing is converting a string to a numeric value
Console.WriteLine("Enter a number");
// Parsing the value being written by the user because Console.ReadLine() is written as a string
int number = int.Parse(Console.ReadLine());
number += 10;
Console.WriteLine(number)
