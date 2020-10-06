using System;
class student
{
    int rn;
    string name;
    string address;
    int marks;
    public void get()
    {
        Console.WriteLine("Enter RollNo");
        rn = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter Name");
        name = Console.ReadLine();
        Console.WriteLine("Enter Address");
        address = Console.ReadLine();
        Console.WriteLine("Enter Marks");
        marks = Convert.ToByte(Console.ReadLine());
    }
    public void show()
    {
        Console.WriteLine("RollNo is {0} " , rn);
        Console.WriteLine("Name is {0}" ,name);
        Console.WriteLine("Address is {0} ", address);
        Console.WriteLine("Marks are {0}",marks);
    }
}
class Program
{
    static void Main()
    {
        student[] s = new student[10];
        for (int i = 0; i < 10; i++)
        {
            s[i] = new student();
            s[i].get();

        }
        for (int i = 0; i < 10; i++)
        {
            s[i].show();
        }
        foreach (student x in s)
        {
            x.show();
        }
    }
}