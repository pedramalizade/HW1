Console.Write("What's Your FirstName: ");
string firstname = Console.ReadLine();

Console.Write("What's Your LastName: ");
string lastname = Console.ReadLine();

Console.Write("Enter Your CodeMeli: ");
string codemeli = Console.ReadLine();
if (codemeli.Length == 10)
{
}
else
{
    Console.WriteLine("incorrect");
    return;
}

Console.Write("Enter Your Date Of Birth (yyyy/MM/dd): ");
string DateOfBirth = Console.ReadLine();
if (DateOfBirth.Length == 10 && DateOfBirth[4] == '/' && DateOfBirth[7] == '/')
{
    string Year = DateOfBirth.Substring(0, 4);
    string Month = DateOfBirth.Substring(5, 2);
    string Day = DateOfBirth.Substring(8, 2);

    if (int.TryParse(Year, out int year) &&
    int.TryParse(Month, out int month) &&
    int.TryParse(Day, out int day))
    {
        if (month >= 1 && month <= 12 && day >= 1 && day <= 30 && year >= 1 && year <= 1403)
        {
        }
        else
        {
            Console.WriteLine("incorrect date");
            return;
        }
    }
    else
    {
        Console.WriteLine("incorrect number! ");
        return;
    }
}
else
{
    Console.WriteLine("incorect format!");
    return;
}



Console.Write("Enter Your Phone Number: ");
string phonenumber = Console.ReadLine();
if (phonenumber.Length == 11 && phonenumber.StartsWith("09"))
{
}
else
{
    Console.WriteLine("incorect");
    return;
}


Console.Write("Enter Your Email: ");
string email = Console.ReadLine();
bool isValid = email.Contains("@") && email.Contains(".") &&
    email.IndexOf('@') == email.LastIndexOf('@') &&
    email.IndexOf('.') == email.LastIndexOf('.');
if (isValid)
{
}
else
{
    Console.WriteLine("Incorrect Email! ");
    return;
}

Console.WriteLine($"Your Name Is: {firstname}");
Console.WriteLine($"Your Last Name Is: {lastname}");
Console.WriteLine($"Your code Meli Is: {codemeli}");
Console.WriteLine($"Your Date Of Birth Is:{DateOfBirth}");
Console.WriteLine($"Your PhoneNumber Is: {phonenumber}");
Console.WriteLine($"Your Email Is: {email}");