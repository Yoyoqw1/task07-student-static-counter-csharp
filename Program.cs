using System;

class Student
{
    public static int Count = 0;
    public string Name;

    public Student(string name)
    {
        Name = name;
        Count++;
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Іван");
        Student s2 = new Student("Олена");
        Student s3 = new Student("Петро");
        Console.WriteLine("Створено студентів: " + Student.Count);
    }
}
