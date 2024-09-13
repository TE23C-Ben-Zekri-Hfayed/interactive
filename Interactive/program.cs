Console.WriteLine("The ship got raided by intergalactic aliens, feared for their ruthless killing. You are stuck in the generator room, what will you do?");
Console.WriteLine("1. Open the door. 2. Find a weapon. 3. Try to signal nearby ships");
string Choice1 = Console.ReadLine();

if (Choice1 == "1")
{
    Console.Clear();
    Console.WriteLine("You opened the door, only to find the aliens staring right back at you. Before you could react, they attack and kill you.");
    Console.WriteLine("Game over...");
    Console.ReadLine(); // Bad Ending 1
}
else if (Choice1 == "2")
{
    Console.Clear();
    Console.WriteLine("You quickly search the room and find a screwdriver.");
    Console.WriteLine("What will you do?");
    Console.WriteLine("1. Block the door hinge (It might make noise).");
    Console.WriteLine("2. Try to open the vent.");
    Console.WriteLine("3. Keep looking for something else.");
    string Choice21 = Console.ReadLine();

    if (Choice21 == "1")
    {
        Console.Clear();
        Console.WriteLine("You try to block the door hinges, but the noise draws the aliens’ attention. They burst in and kill you.");
        Console.WriteLine("Game over...");
        Console.ReadLine(); // Bad Ending 2
    }
    else if (Choice21 == "2")
    {
        Console.Clear();
        Console.WriteLine("You manage to open the vent and crawl inside, barely escaping the aliens. You continue crawling through the ducts, unsure of where it leads.");
        Console.WriteLine("Suddenly, you find yourself in the engine room. It's noisy, but it looks like there might be an escape pod nearby.");
        Console.WriteLine("What will you do?");
        Console.WriteLine("1. Investigate the escape pod.");
        Console.WriteLine("2. Stay hidden in the ducts.");
        string Choice22 = Console.ReadLine();

        if (Choice22 == "1")
        {
            Console.Clear();
            Console.WriteLine("You dash for the escape pod. The aliens notice your movement, but you're fast. You launch the pod just in time, narrowly avoiding capture.");
            Console.WriteLine("You successfully escape the ship. Congratulations, you survived!"); // Good Ending
            Console.ReadLine();
        }
        else if (Choice22 == "2")
        {
            Console.Clear();
            Console.WriteLine("You stay hidden in the ducts for too long. The aliens sweep the area, eventually finding you. You were so close, but now it's over.");
            Console.WriteLine("Game over...");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid choice.");
        }
    }
    else if (Choice21 == "3")
    {
        Console.Clear();
        Console.WriteLine("As you continue to search, time runs out. The aliens break in, and you are caught off guard.");
        Console.WriteLine("Game over...");
        Console.ReadLine(); // Bad Ending 3
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid choice.");
    }
}
else if (Choice1 == "3")
{
    Console.Clear();
    Console.WriteLine("You attempt to signal other ships for help, but the aliens have cut the communication system.");
    Console.WriteLine("What will you do now?");
    Console.WriteLine("1. Try to repair it.");
    Console.WriteLine("2. Leave it alone.");
    string Choice31 = Console.ReadLine();

    if (Choice31 == "1")
    {
        Console.Clear();
        Console.WriteLine("You try to repair the system, but it's too late. The aliens have already reached your location...");
        Console.WriteLine("Game over...");
        Console.ReadLine(); // Bad Ending 4
    }
    else if (Choice31 == "2")
    {
        Console.Clear();
        Console.WriteLine("You leave the communication system alone, knowing it's a lost cause. You must find another way out. You turn and head deeper into the ship.");
        Console.WriteLine("After running for a while, you stumble upon a hidden maintenance hatch. It seems to lead to the lower deck.");
        Console.WriteLine("What will you do?");
        Console.WriteLine("1. Enter the hatch.");
        Console.WriteLine("2. Keep searching.");
        string Choice32 = Console.ReadLine();

        if (Choice32 == "1")
        {
            Console.Clear();
            Console.WriteLine("You enter the maintenance hatch, avoiding the aliens. After a long crawl, you emerge in an escape pod bay.");
            Console.WriteLine("With the aliens hot on your trail, you launch the pod just in time and escape the ship.");
            Console.WriteLine("You successfully survive! Congratulations!"); // Good Ending (alternate)
            Console.ReadLine();
        }
        else if (Choice32 == "2")
        {
            Console.Clear();
            Console.WriteLine("You decide to keep searching, but the aliens find you before you can reach safety.");
            Console.WriteLine("Game over...");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid choice.");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid choice.");
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Invalid choice.");
}
