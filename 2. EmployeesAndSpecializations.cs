

using System.ComponentModel;

public class Employee
{
    //Variables
    string name = "NO NAME";
    int salary = -1;

    //Gets & Sets
    string Name { get { return name; } set { name = value; } }

    int Salary { get { return salary; } set { salary = value; } }

    //Constructors 
    public Employee() { /* Empty construcor */  }

    public Employee(string aName, int aSalary)
    {
        Name = aName;
        Salary = aSalary;
    }

    //Methods 
    public override string ToString()
        { return $"Employee:{Name}   Salary:${Salary}  "; }
}

public class Manager : Employee
{
    //Varibales
    private int numberOfEmployeesManaged = 0;

    //Gets & Sets
    public int NumberOfEmployeesManaged { get { return numberOfEmployeesManaged; } set { numberOfEmployeesManaged = value; } }

    //Constructors 
    public Manager() { /* Empty Constructor */ }

    public Manager(string aName, int aSalary, int aNumberOfEmployees) : base(aName, aSalary)
    {
        numberOfEmployeesManaged = aNumberOfEmployees;
    }

    //Methods 
    public override string ToString()
    {
        return $"{base.ToString()} Number of Employees: {numberOfEmployeesManaged}";
    }
}

public class Engineer : Employee
{
    //Variables 
    string specialization = "None";

    //Gets & Sets
    public string Specialization { get { return specialization; } set { specialization = value; } }

    //Constructors
    public Engineer() { /* Empty Constructor */ }

    public Engineer(string aName, int aSalary, string aSpecialization) : base(aName, aSalary)
    {
        specialization = aSpecialization;
    }

    //Methods 
    public override string ToString()
    {
        return $"{base.ToString()} Specialization: {specialization}";
    }
}

class Program
{
    static void Main()
    {
        Employee Ben = new Employee("Ben", 10);
        Manager Anna = new Manager("Anna", 20, 2);
        Engineer Aidan = new Engineer("Aidan", 20, "cars");

        object[] workers = {Ben,Aidan,Anna};

        foreach (object worker in workers)
        {
            Console.WriteLine(worker + "\n\n");
            
        }

 
    }

}