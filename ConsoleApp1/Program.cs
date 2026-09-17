int Knuckleshp = 100;
int MechaKnuckleshp2 = 100;

string knucklesName = "KNUCKLES";
string mechaknucklesName = "MECHAKNUCKLES";

while (Knuckleshp > 0 && MechaKnuckleshp2 > 0)
{
    Console.WriteLine("\n DEATH MATCH");
    Console.WriteLine($"{knucklesName}: {Knuckleshp} {mechaknucklesName}: {MechaKnuckleshp2}\n");
    
    int knucklesDamage = Random.Shared.Next(20);
    MechaKnuckleshp2 -= knucklesDamage;
    MechaKnuckleshp2 = Math.Max(0, MechaKnuckleshp2);
    Console.WriteLine($"{knucklesName} does {knucklesDamage} damage on {mechaknucklesName}");

    int mechaknucklesDamage = Random.Shared.Next(20);
    Knuckleshp -= mechaknucklesDamage;
    Knuckleshp = Math.Max(0, Knuckleshp);
    Console.WriteLine($"{mechaknucklesName} does {mechaknucklesDamage} damage on {knucklesName}");

    Console.WriteLine("Press any button to continue");
    Console.ReadKey();
}

Console.WriteLine("\n BATTLE OVER");

if (Knuckleshp == 0 && MechaKnuckleshp2 == 0)
{
    Console.WriteLine("WHAT?! NO WINNER?");
}
else if (Knuckleshp == 0)
{
    Console.WriteLine($"{mechaknucklesName} HAS BESTED THE ORIGINAL AND PROVEN HIMSELF SUPERIOR!");
}
else
{
    Console.WriteLine($"{knucklesName} HAS DEFEATED HIS ROBOTIC COUNTERPART AND HAS SHOWED WHY HE'S THE REIGNING CHAMPION!");
}

Console.WriteLine("Press anything to leave");
Console.ReadKey();

// Console.WriteLine("Hello, World!");
// int damage = Random.Shared.Next(5, 11);
// Console.WriteLine(damage);

Console.ReadLine();