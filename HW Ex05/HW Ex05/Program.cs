Console.Write("adad 3 raghami vared konid: ");
int number = int.Parse(Console.ReadLine());

int digit1 = number / 100;
int digit2 = (number / 10) % 10;
int digit3 = number % 10;

bool result = (digit1 + digit3) == digit2;
Console.WriteLine(result);