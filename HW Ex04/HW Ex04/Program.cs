Console.Write("Enter a Number one: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter a Number Two: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter a Number Three: ");
int num3 = int.Parse(Console.ReadLine());

Console.Write("Enter a Number Four: ");
int num4 = int.Parse(Console.ReadLine());

Console.Write("Enter a Number Five: ");
int num5 = int.Parse(Console.ReadLine());

int roundedAvrage = (num1 + num2 + num3 + num4 + num5) / 5;
Console.WriteLine($"Rounded Avrage: {roundedAvrage}");

bool isEven = roundedAvrage % 2 == 0;
Console.WriteLine(isEven);