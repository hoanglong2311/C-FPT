namespace Exercise2;

public class Person
{
    private int age;
    private string name;

    public Person()
    {
        
    }
    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    //method display person's name and age
    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    
    //method to input person's name and age
    public void InputPerson()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());
    }
    
    public override string ToString()
    {
        return $"Name: {name}, Age: {age}";
    }
    
    
}