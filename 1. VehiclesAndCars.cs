using System.Reflection;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        Motercycle Motercycle = new Motercycle("Harley-Davidson", "Sportster", 2021, false);
        Car PickupTruck = new Car("Ford", "Explorer", 2005, 4);

        Console.WriteLine(PickupTruck);
        Console.WriteLine(Motercycle);

    }
}


class Vehicle
{
    //Class Variables
    string make = "n/a";
    string model = "n/a";
    int year = 1;

    //Gets & Sets
    string Make
    { get { return make; } set { make = value; } }
    string Model
    { get { return model; } set { model = value; } }
    int Year
    { get { return year; } set {if (year > 0){ year = value;} } }

    public Vehicle() { }

    public Vehicle(string aMake, string aModel, int aYear) 
    {
        this.Make = aMake;
        this.Model = aModel;
        this.Year = aYear;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

class Car : Vehicle
{
    //Variables
    int numdoors = 0;

    //Gets & Set
    public int NumDoors { get { return numdoors; } set { numdoors = value; } }


    //Constructor
    public Car() { }
    
    public Car(string aMake, string aModel, int aYear, int numberofdoors)
        : base (aMake, aModel, aYear)
    {
        numdoors = numberofdoors;
    }

    //ToString()
    public override string ToString()
    {
        return $"{base.ToString()} with {numdoors} doors";
    }

}

class Motercycle : Vehicle
{
    //Variables
    bool SideCar = false;

    public Motercycle() { }

    public Motercycle(string aMake, string aModel, int aYear, bool HasSideCar) : base (aMake, aModel, aYear) 
    {
        SideCar = HasSideCar;
    }

    //ToString()
    public override string ToString()
    {
        return $"{base.ToString()} Has Sidecar: {SideCar}";
    }
}