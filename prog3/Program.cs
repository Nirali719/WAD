Console.WriteLine("Available Arithmatic operaters : Addition , Subtraction , Multiplication  , Divison and Modulus");
Console.Write("which operation do you want to perform : ");
String op = Console.ReadLine();

Console.Write("enter number 1 : ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("enter number 2 : ");
double num2 = double.Parse(Console.ReadLine());

double result = op switch
{
    "Addition" => num1 + num2,
    "Subtraction" => num1 - num2,
    "Multiplication" => num1 * num2,
    "Divison" => num1 / num2,
    "Modulus" => num1 % num2
};
Console.WriteLine($"{op} of {num1} and {num2} is {result}");
