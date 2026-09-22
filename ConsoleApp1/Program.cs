int Knuckleshp = 100;
int Sonichp2 = 100;

string knucklesName = "KNUCKLES";
string sonicName = "SONIC";

while (Knuckleshp > 0 && Sonichp2 > 0)
{
    Console.WriteLine("\n DEATH MATCH");
    Console.WriteLine($"{knucklesName}: {Knuckleshp} {sonicName}: {Sonichp2}\n");
    
    int knucklesDamage = Random.Shared.Next(20);
    Sonichp2 -= knucklesDamage;
    Sonichp2 = Math.Max(0, Sonichp2);
    Console.WriteLine($"{knucklesName} does {knucklesDamage} damage on {sonicName}");

    int sonicDamage = Random.Shared.Next(20);
    Knuckleshp -= sonicDamage;
    Knuckleshp = Math.Max(0, Knuckleshp);
    Console.WriteLine($"{sonicName} does {sonicDamage} damage on {knucklesName}");

    Console.WriteLine("Press any button to continue");
    Console.ReadKey();
}

Console.WriteLine("\n BATTLE OVER");

if (Knuckleshp == 0 && Sonichp2 == 0)
{
    Console.WriteLine("WHAT?! NO WINNER?");
}
else if (Knuckleshp == 0)
{
    Console.WriteLine($"{sonicName} HAS BESTED THE ECHIDNA WARRIOR ONCE AGAIN!");
}
else
{
    Console.WriteLine($"{knucklesName} HAS DEFEATED THE BLUE BLUR AND HAS CLAIMED THE TITLE OF CHAMPION!");
}

Console.WriteLine("Press anything to leave");
Console.ReadKey();

// Console.WriteLine("Hello, World!");
// int damage = Random.Shared.Next(5, 11);
// Console.WriteLine(damage);

