try
{
    Console.WriteLine("Enter the number");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine($"You enter number {x}");
}
catch
{
    Console.WriteLine("You not enter the number");
}

