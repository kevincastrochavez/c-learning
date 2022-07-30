﻿// int num1;
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




///////////// PARSING STRING TO INTERGER ////////////

string name = "Kevin";
int age = 25;

// String Concatenation
Console.WriteLine("Hello, my name is " + name + ". I'm " + age + " years old");

// String Formatting
Console.WriteLine("Hello, my name is {0}. I'm {1} years old", name, age);

// String Formatting
Console.WriteLine($"Hello, my name is {name}. I'm {age} years old");

// Verbatim Strings
// Takes string literally and ignores any spaces or escape characters like \n
Console.WriteLine(@"Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old. Hello, my name is Kevin. I'm 25 years old");