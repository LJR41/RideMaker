class Vehicle
{
    public string Name;
    public int Passengers;
    public string Color;
    public bool HasEngine;
    public int Miles;


    public Vehicle(string name, int passengers, string color, bool hasengine){
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasengine;
        Miles = 0;
    }

    public Vehicle(string name, string color){
        Name = name;
        Passengers = 2;
        Color = color;
        HasEngine = true;
        Miles = 0;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Vehicle Name: {Name}, Number of Passengers: {Passengers}, Color: {Color}, Has an engine: {(HasEngine? "Yes": "No")}, Miles: {Miles}");
    }

    public void Travel(int data)
    {
        Miles += data;
        Console.WriteLine($"The {Name} now has {Miles} travelled.");
    }
}