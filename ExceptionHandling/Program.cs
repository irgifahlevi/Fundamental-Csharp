// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

try
{
    Console.Write("Enter a number : ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number : ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();

