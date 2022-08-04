// int num1;
// num1 = 13;
// int num2 = 10;
// int num3, num4, num5; // Declaring many variables at the same time
// // num2 = 100; Can be overwritten

// int sum = num1 + num2;

// Console.WriteLine($"Number 1: {num1} plus Number 2: {num2} is equal to: {sum}");

// double d1 = 3.1416;
// double d2 = 5.1;
// double doubleResult = d1 / d2;
// Console.WriteLine(doubleResult); 

// float f1 = 3.1416f;
// float f2 = 5.1f; // Declare explicitly that it is a double
// float floatResult = f1 / f2;
// Console.WriteLine(floatResult); 

// The string datatype comes from System, using the String class
// string myName = "Kevin";
// string capsString = myName.ToUpper();
// string lowerString = myName.ToLower();

// Console.WriteLine(myName);
// Console.WriteLine(capsString);
// Console.WriteLine(lowerString);

// Console.WriteLine("Cursor in different line");
// Console.Write("Cursor in same line");
// string readInput = Console.ReadLine();
// int readAsciiValue = Console.Read();


// Console.WriteLine(readInput);
// Console.WriteLine(readAsciiValue); // Gets the Ascii value




// //////////// IMPLICIT AND EXPLICIT CONVERSION ////////////

// // Explicit conversion
// double myDouble = 13.37;
// int myInt;

// // CASTING
// myInt = (int)myDouble;
// Console.WriteLine(myInt);

// // Implicit conversion
// int num = 12345;
// long bigNum = num;

// float myFloat = 13.37;
// double myOtherDouble = myFloat;

// // Type conversion
// string myString = myDouble.ToString();




// ///////////// PARSING STRING TO INTERGER ////////////

// string myString = "15";
// string mySecondString = "13";
// int numOne = Int32.Parse(myString);
// int numTwo = Int32.Parse(mySecondString);

// int result = numOne + numTwo;

// Console.WriteLine(result);




// ///////////// PARSING STRING TO INTERGER ////////////

// string name = "Kevin";
// int age = 25;

// // String Concatenation
// Console.WriteLine("Hello, my name is " + name + ". I'm " + age + " years old");

// // String Formatting
// Console.WriteLine("Hello, my name is {0}. I'm {1} years old", name, age);

// // String Formatting
// Console.WriteLine($"Hello, my name is {name}. I'm {age} years old");

// // Verbatim Strings
// // Takes string literally and ignores any spaces or escape characters like \n
// Console.WriteLine(@"Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old");



// ///////////// STRING METHODS ////////////

// string firstName = " Kevin Castro";

// Console.WriteLine(firstName.ToUpper());
// Console.WriteLine(firstName.ToLower());
// Console.WriteLine(firstName.Substring(4));
// Console.WriteLine(firstName.Trim());
// Console.WriteLine(firstName.IndexOf("C"));
// Console.WriteLine(String.IsNullOrWhiteSpace(firstName));




// ///////////// CHALLENGE ////////////

// Console.Write("Enter a string here: ");
// string enteredString = Console.ReadLine();

// Console.Write("Enter the character to search from the string you just entered: ");
// string characterToSearch = Console.ReadLine();

// int indexOfCharacter = enteredString.IndexOf(characterToSearch);
// Console.WriteLine($"The index of the character you are searching is: {indexOfCharacter}");




// ///////////// CONSTANTS ////////////

// public class Program
// {
//     const double PI = 3.14159265359;
//     const int weeks = 52, months = 12;

//     static void Main()
//     {
        
//     }
// }



// ///////////// VOID METHODS ////////////

// public class Program
// {
//     static void Main(string[] args)
//     {
//         GreetFriend("Citlalli");
//         GreetFriend("Cindy");
//         GreetFriend("David");
//     }
    
//     public static void  GreetFriend(string friend)
//     {
//         try
//         {
//             Console.WriteLine($"Hi {friend}, my friend!");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("Some wierd exception");
//         }
//         finally // Called anyways
//         {
//             Console.WriteLine("Finished");
//         }
//     }
// }



// ///////////// OPERATIONS ////////////

// int num = 1;

// Console.WriteLine(++num);
// Console.WriteLine(num++);




// ///////////// CONDITIONS ////////////

// Console.WriteLine("What's the current temperature");
// int temperature = int.Parse(Console.ReadLine());

// if (temperature > 50)
// {
//     Console.WriteLine("Greater that 50");
// }

// if (temperature < 50)
// {
//     Console.WriteLine("Lower that 50");
// }



// ///////////// TRYPARSE ////////////

// Console.WriteLine("What's the current temperature");
// string temperature = Console.ReadLine();
// int numTemp;
// int number;

// if (int.TryParse(temperature, out number))
// {
//     numTemp = number;
// } 
// else
// {
//     numTemp = 0;
//     Console.WriteLine("Value entered was not a number. 0 set as temperature");
// }



// ///////////// SWITCH ////////////

// int age = 25;

// switch (age)
// {
//     case 10:
//         Console.WriteLine("Age is 10");
//         break;
//     case 15:
//         Console.WriteLine("Age is 15");
//         break;
//     case 25:
//         Console.WriteLine("You got it");
//         break;
//     default:
//         Console.WriteLine("Not valid");
//         break;
// }



///////////// TERNARY OPERATOR ////////////

// int temperature = 5;

// string stateOfMatter = temperature < 0 ? "Solid" : "Liquid";
// Console.WriteLine($"State of matter is {stateOfMatter}");



///////////// EXERCISE PARSING ////////////

// using System.Globalization;

// string stringForFloat = "0.85"; // datatype should be float
// string stringForInt = "12345"; // datatype should be int

// int intParsed = Int32.Parse(stringForInt);
// float floatParsed = float.Parse(stringForFloat, CultureInfo.InvariantCulture.NumberFormat);

// Console.WriteLine(intParsed);
// Console.WriteLine(floatParsed);



///////////// LOOPS ////////////

int counter = 0;

// for (var counter = 0; counter < 10; counter++)
// {
//     Console.WriteLine(counter);
// }

// do
// {
//     Console.WriteLine("Counter increasing");
//     counter++;
// } while (counter < 10);

// while (counter < 10)
// {
//     Console.WriteLine("Increasing counter");
//     counter++;
// }