using System.Reflection;
using System.Security.AccessControl;

public class Animal
{
    //Variables
    string name = "No Name";
    //Gets & Sets
    string Name { get { return name; } set { name = value; } }

    //Constructor
    public Animal() { /* Empty Constructor */ }

    public Animal(string aName)
    { Name = aName; }

    //Methods
    public virtual string MakeSound()
    { return "Some generic animal sound"; }

    public override string ToString()
    {
        return $"Animal: {Name} , Sound:{MakeSound()}";
    }
}

public class Dog : Animal
{
    private string Name;

    public Dog(string aName) : base(aName)
    {
        Name = aName;
    }

    public override string MakeSound()
    {
        return "Bark";
    }
}

public class Cat : Animal
{
    private string Name;

    public Cat(string aName) : base(aName)
    {
        Name = aName;
    }

    public override string MakeSound()
    {
        return "Meow";
    }
}



class Program
{
    static void Main()
    {
        Dog Yaddi = new Dog("Yaddi");

        Cat Princess = new Cat("Princess");

        object[] Animals = { Yaddi, Princess};

        foreach (object Animal in Animals)
        {
            Console.WriteLine(Animal.ToString());
            Console.WriteLine("\n\n");
        }



    }


}