using System;

namspace ObjectOriented;

public abstract class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Print();
}
public class Student : Person
{
    public int Year;
    public float Gpa;

    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        year = year;
        Gpa = gpa;
    }

    public override void Print()
    {
        Console.WriteLine($"My name is {Name}, my age is {Age}, and my gpa is {Gpa}")
    }
}

public class Database
{
    private int _currentIndex;

    public Person[] People = new Person[50];

    public void AddStudent(Student student)
    {
        People[_currentIndex++] = student;
    }
}

public class Task
{
    private static void Main()
    {
        var database = new Database();
        Console.Write("Name: ");
        var name = Console.ReadLine();

        Console.Write("Age: ");
        var age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Year: ");
        var year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Gpa: ");
        var gpa = Convert.ToSingle(Console.ReadLine());

        var student = new Student(name, age, year, gpa);

        database.AddStudent(student);

    }
}