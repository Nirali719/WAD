int snum = 8427;
int count = 0;
while (true)
{
    count++;
    Console.Write("Guass the number : ");
    int gnum = int.Parse(Console.ReadLine());
    if (gnum == snum)
    {
        break;
    }
    else if (gnum > snum)
    {
        Console.WriteLine("sorry , the number is too high");
    }
    else
    {
        Console.WriteLine("sorry , number is too low");
    }
}
Console.WriteLine($"congrats you Guass the number in {count} attemp");

