Console.WriteLine("The ship got raided by intergalactic aliens, feared by their ruthless killing, you are stuck in the generator room, what will you do?");
Console.WriteLine("1. Open the door. 2. Find a weapon. 3. Try to signal nearby ships");
String Choice1 = Console.ReadLine();

if (Choice1 == "1")
{
    Console.Clear();
    Console.WriteLine("You opened the door to see the aliens staring right back at you, they kill you...");
    Console.WriteLine("Game over..");
    Console.ReadLine();

}
else if (Choice1 == "2")
{
    Console.Clear();
    Console.WriteLine("You look for a weapon and luckily find a Screwdriver.");
    Console.WriteLine("");
    Console.WriteLine("What will you do?");
    Console.WriteLine("");
    Console.WriteLine("1. Block the door hinge(Makes sound). 2. Attempt to open the vents. 3. Find something else");
     Console.ReadLine();
 String Choice21 = Console.ReadLine();
 {
 Console.Clear();
 Console.WriteLine("You attempt to block the hinges to the door.");
 Console.WriteLine("");
 Console.WriteLine("Congratulations, you alerted the aliens and they stormed the room and killed you...");
 Console.ReadLine();
 Console.WriteLine("Game over....");
 }

    
}
else if (Choice1 == "3")
{
    Console.Clear();
    Console.WriteLine("You try to signal other nearby ships for help, but you notice the aliens cut off the communication system.");
    Console.WriteLine();
    Console.WriteLine("What will you do now?");
    Console.ReadLine();

}