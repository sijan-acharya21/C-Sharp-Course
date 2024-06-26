// Do while loop will execute the body at least once whereas while loop does not

// While loop syntax
int x = 5;
while (x > 6) { // While loop does not run because 
  Console.WriteLine("Hello");
}

// Do while loop syntax
int i = 5;
do {
  Console.WriteLine("Hello");
  ;
} while (i > 6);

// While loop example
Console.WriteLine("hello");
string response = Console.ReadLine();
while (response == "again") {
  Console.WriteLine("hello");
  response = Console.ReadLine();
}

// Do while loop example
string input;
do {
  Console.WriteLine("hello"); // Executes the body first regardless of the condition
  input = Console.ReadLine(); 
} while (input == "again");
