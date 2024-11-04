using System;
public abstract class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
    public abstract void Duty();
}
public class SoftwareDeveloper : Employee
{
    public override void Duty()
    {
        Console.WriteLine($"{FirstName} {LastName} is a Software Developer and says, \"I am developing software.\"");
    }
}
public class ProjectManager : Employee
{
    public override void Duty()
    {
        Console.WriteLine($"{FirstName} {LastName} is a Project Manager and says, \"I am managing projects.\"");
    }
}
public class SalesRepresentative : Employee
{
    public override void Duty()
    {
        Console.WriteLine($"{FirstName} {LastName} is a Sales Representative and says, \"I am making sales.\"");
    }
}

class Program
{
    static void Main()
    {
        Employee dev = new SoftwareDeveloper
        {
            FirstName = "Ali",
            LastName = "Kara",
            Department = "Software"
        };
        dev.Duty();

        Employee pm = new ProjectManager
        {
            FirstName = "Hasan",
            LastName = "Çıldırmış",
            Department = "Project Management"
        };
        pm.Duty();

        Employee salesRep = new SalesRepresentative
        {
            FirstName = "Ayşe",
            LastName = "Yılmaz",
            Department = "Sales"
        };
        salesRep.Duty();
    }
}
