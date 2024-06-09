﻿// Example file for C# Applied Data Structures by Joe Marini
// Basic data structures

// TODO: strings are collections of characters, and are immutable
string str = "Gourav Dash  loves ";
char[] c1 = new char[] {'F','i','z','z','y',' ','B','u','z','z'};
string str2 =  new string(c1);
str  += str2;

Console.WriteLine(str);

str2 = str2.ToUpper();
Console.WriteLine(str2);


// TODO: Be careful with string references


// TODO: Arrays are contiguous storage of the same variable type


// TODO: implicitly typed array


// TODO: multiple type array


// TODO: Tuples are lightweight data structures that group multiple data elements

