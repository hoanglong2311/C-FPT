namespace Exercise2;

public class Student: Person
{
    private double gpa;

    public Student(double gpa)
    {
        this.gpa = gpa;
    }

    public Student(string name, int age, double gpa) : base(name, age)
    {
        this.gpa = gpa;
    }
    
    //method to display student info
    public void DisplayStudentInfo() 
    {
    }
    
    //method to input student info
    public void InputStudentInfo()
    {
    }
    
}