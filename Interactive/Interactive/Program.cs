
Console.WriteLine("As you venture through deep space, you ecounter a ship; it's sending distress signals, what will you do?");
Console.WriteLine("1. Ignore the distress signal.  2. Reply to their signal.   3. Bomb their ship");
String Choice1 = Console.ReadLine();

if (Choice1 == "1")
{
    Console.Clear();
    Console.WriteLine("You ignore the distress signal and you venture off to the distance.");
    Thread.Sleep(4500);
    Console.WriteLine("Game Over");
    String Choice12 = Console.ReadLine();
} 
else if (Choice1 == "2")
{

Console.Clear();
Console.WriteLine("As you let them into your ship, they shoot you with the ultra-matter pistol, erasing you from existence");
Thread.Sleep(4500);
Console.Clear();
Console.WriteLine("Game over");
Console.ReadLine();

}



