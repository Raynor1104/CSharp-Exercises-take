// See https://aka.ms/new-console-template for more information

// How many days of a month
int day31 = 31;
int day30 = 30;
int day29 = 29;
int day28 = 28;
int year = 2021;
int month = 2;
if(month == 1 && month == 3 && month == 5 && month == 7 && month == 8 && month == 10 && month == 12){
    Console.WriteLine(day31);
}
else if (month == 4 && month == 6 && month == 9 && month == 11) {
    Console.WriteLine(day30);
}
else if (month == 2 && year % 4 == 0){
    Console.WriteLine(day29);
}
else {
    Console.WriteLine(day28);
}
Console.WriteLine("\n");

// Multiplication table 
for (int i = 1; i <= 9; i++) {
    for (int j = 1; j <=10; j++) {
        int ij = i * j;
        Console.WriteLine($"{i} x {j} = {ij}");
    }
}
Console.WriteLine("\n");

// Perform operation and display
int firstnum = 20;
int secondnum = 12;
string operation = "-";
int minus = firstnum - secondnum;
int plus = firstnum + secondnum;
int divide = firstnum / secondnum;
int multiple = firstnum * secondnum;

if (operation == "+") {
    Console.WriteLine($"{firstnum} {operation} {secondnum} = {plus}");
}
if (operation == "-") {
    Console.WriteLine($"{firstnum} {operation} {secondnum} = {minus}");
}
if (operation == "x") {
    Console.WriteLine($"{firstnum} {operation} {secondnum} = {multiple}");
}
if (operation == "/") {
    Console.WriteLine($"{firstnum} {operation} {secondnum} = {divide}");
}
Console.WriteLine("\n");

// Perimeter of Circle
double circle_radius = 12;
double circle_perimeter = circle_radius * 2 * Math.PI;

Console.WriteLine($"Perimeter of Circle: {circle_perimeter}");
Console.WriteLine("\n");
// Check symbol
string symbol = "a";
if (symbol == symbol.ToLower() && symbol == "u" || symbol == "e" || symbol == "o" || symbol == "a" || symbol == "i"){
    Console.WriteLine("It's a lowercase vowel.");
} else if (symbol == "1" || symbol == "2" || symbol == "3" || symbol == "4" || symbol == "5" || symbol == "6" || symbol == "7" || symbol == "8" || symbol == "9") {
    Console.WriteLine("It's a degit.");
} else{
    Console.WriteLine("It's an other symbol.");
}
Console.WriteLine("\n");
