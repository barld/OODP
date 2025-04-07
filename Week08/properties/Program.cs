namespace properties;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        var student = new Student("11212") {FirstNames = "Bartel Andreas"};

        Console.WriteLine(student.Initials);
    }
}

public class Student
{

    private string firstNames;

    public string FirstNames 
    {
        //get { return firstNames; }
        get => firstNames;
        set { firstNames = value; }
    }

    public string LastName { get; private set; }

    public string StudentNumber { get; }

    public string FullName => $"{FirstNames} {LastName} ({StudentNumber})";

    // public string Initials => string.Join(".", this.firstNames.Split(" ").Select(name => name[0])) + ".";
    public string Initials {
        get 
        {
            string result = "";
            foreach (string name in firstNames.Split(" "))
            {
                result += name[0] + ".";
            }

            return result;
        }
    }


    public Student(string studentNumber)
    {
        StudentNumber = studentNumber;
    }
}

public abstract class Device
{
    public virtual string Name { get; set; }

    public abstract void TurnOn();

    public void TestDevice()
    {
        this.TurnOn();
    }
}

public class Printer : Device
{
    public override string Name 
    { 
        get => base.Name + " (printer)"; 
        set => base.Name = value; 
    }

    public override void TurnOn()
    {
        Console.WriteLine("I'm ready to print");
    }
}