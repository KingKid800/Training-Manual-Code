int addition(int x, int y)
{
    int z = x + y;
    return z;
}


Console.WriteLine("Gimme a number: ");
string numberOneString = Console.ReadLine();
while (true) 
{
    if (numberOneString.Length == 0)
    {
        Console.WriteLine("Give me some input please!");
        Console.WriteLine("Gimme a number: ");
        numberOneString = Console.ReadLine();
    }
    else
    {
        break;
    }
}
int numberOne = Int32.Parse(numberOneString);


Console.WriteLine("Gimme another number: ");
string numberTwoString = Console.ReadLine();
while (true)
{
    if (numberTwoString.Length == 0)
    {
        Console.WriteLine("Give me some input please!");
        Console.WriteLine("Gimme a number: ");
        numberTwoString = Console.ReadLine();
    }
    else
    {
        break;
    }
}
int numberTwo = Int32.Parse(numberTwoString);


int result = addition(numberOne, numberTwo);
Console.WriteLine("Result: " + result);
