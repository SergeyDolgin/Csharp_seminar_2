void secondDigit ()
{
try
{
    Console.Write("Enter three-digits number ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n-100 > 0 && n-1000 < 0)
    {
        Console.WriteLine("Second digit is "+((n / 10) % 10));
    }
    else 
    {
        Console.WriteLine("You have entered not three-digits number");
    }
}
    catch
    {
   }
}
   secondDigit ();
