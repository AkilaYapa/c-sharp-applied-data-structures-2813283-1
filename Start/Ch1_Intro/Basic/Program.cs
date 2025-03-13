// Example file for C# Applied Data Structures by Joe Marini
// Basic data structures

// TODO: strings are collections of characters, and are immutable

string s1 = "Hello world ";
char[] c1 = new char[] {'F','i','z','z','y',' ','B','u','z','z'};
string s2 = new string(c1);
s1 += s2;

s2 = s2.ToUpper();

Console.WriteLine(s1);
Console.WriteLine(s2);


// TODO: Be careful with string references

string s3 = "Hello ";
string s4 = s3;
s3 += "World";

Console.WriteLine(s3);
Console.WriteLine(s4);

// TODO: Arrays are contiguous storage of the same variable type
int[] nums = new int[5];
int[] nums2 = {2,54,6,3};

// TODO: implicitly typed array
var arr = new[] {"er", "wes", "bmw"};

// TODO: multiple type array   
object[] obj = {3,"str", 4.3, true, false};

// TODO: Tuples are lightweight data structures that group multiple data elements

(string, int, bool) t1 = ("abc", 4, true);
Console.WriteLine($"{t1.Item1}, {t1.Item2}");

(string a, int b, bool c) t2 = ("asd", 5, false);
Console.WriteLine($"{t2.a}, {t2.b}, {t2.c}");

var t3 = (x: "ssd", y: 6, z: false);
Console.WriteLine($"{t3.x}, {t3.y}, {t3.z}");