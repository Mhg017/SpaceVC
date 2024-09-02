using System;

class Program
{
    static void Main(string[] args)
    {
        var fleet = new CustomArray<Spaceship>();

        var spaceship1 = new Spaceship("Explorer One", "X1", 5, 15000, Status.Active, new DateTime(2023, 5, 1), MissionType.Research);
        var spaceship2 = new Spaceship("Transporter", "T1", 20, 12000, Status.Maintenance, new DateTime(2022, 3, 15), MissionType.Transport);

        fleet.Add(spaceship1);
        fleet.Add(spaceship2);

        Console.WriteLine("Fleet:");
        fleet.PrintAll();

        var map = new Custom2DArray<Spaceship>(10, 10);
        map.SetElement(0, 0, spaceship1);
        map.SetElement(1, 1, spaceship2);

        Console.WriteLine("\nMap:");
        map.PrintAll();
    }
}
