Console.Write("Enter Number one: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter Number two: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter Number three: ");
int num3 = int.Parse(Console.ReadLine());

int temp;
if (num1 > num2)
{
    temp = num1;
    num1 = num2;
    num2 = temp;
}
if (num1 > num3)
{
    temp = num1;
    num1 = num3;
    num3 = temp;
}
if (num2 > num3)
{
    temp = num2;
    num2 = num3;
    num3 = temp;
}
Console.WriteLine("adad be sorat soodi: ");
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);