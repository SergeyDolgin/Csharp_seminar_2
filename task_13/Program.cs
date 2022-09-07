void thirdDigit ()
{
try
{
    Console.Write("Enter three-digits or more digits number ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n-100 > 0 && n-1000 < 0)
    {
        Console.WriteLine("three digit is "+(n  % 10));
    }
    if (n-1000 > 0 && n-10000 < 0)
    {
        Console.WriteLine("three digit is "+(n  / 10) % 10);
    }
    if (n-10000 > 0 && n-100000 < 0)
    {
        Console.WriteLine("three digit is "+(n  / 100) % 10);
    }
    if (n-100000 > 0 && n-1000000 < 0)
    {
        Console.WriteLine("three digit is "+(n  / 1000) % 10);
    }
    if (n < 100 )
    {
        Console.WriteLine("Threre is no third digit");
    }
}
catch
{
    Console.WriteLine("You have entered not a number");
}
}

thirdDigit ();

