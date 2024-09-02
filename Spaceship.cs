using System;

public enum Status { Active, Inactive, Maintenance }
public enum MissionType { Research, Transport, Military, Communications }

public class Spaceship
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int CrewCapacity { get; set; }
    public double MaxSpeed { get; set; }
    public Status ShipStatus { get; set; }
    public DateTime LaunchDate { get; set; }
    public MissionType ShipMission { get; set; }

    public Spaceship(string name, string model, int crewCapacity, double maxSpeed, Status status, DateTime launchDate, MissionType mission)
    {
        Name = name;
        Model = model;
        CrewCapacity = crewCapacity;
        MaxSpeed = maxSpeed;
        ShipStatus = status;
        LaunchDate = launchDate;
        ShipMission = mission;
    }

    public override string ToString()
    {
        return $"{Name} ({Model}), Crew: {CrewCapacity}, Max Speed: {MaxSpeed}, Status: {ShipStatus}, Launch Date: {LaunchDate.ToShortDateString()}, Mission: {ShipMission}";
    }
}
