Console.Write("Enter number one: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter number two: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter number three: ");
int num3 = int.Parse(Console.ReadLine());

Console.Write("Enter number four: ");
int num4 = int.Parse(Console.ReadLine());

Console.Write("Enter number five: ");
int num5 = int.Parse(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
if (num4 > max)
{
    max = num4;
}
if (num5 > max)
{
    max = num5;
}
Console.WriteLine($"the bigest number is: {max}");