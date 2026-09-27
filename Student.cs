using System;

class Student
{
    public string Name;
    public string StudentId;

    public void ShowInfo()
    {
        Console.WriteLine("Ho ten: " + Name);
        Console.WriteLine("MSSV: " + StudentId);
    }
}

public void UpdateInfo()
{
    Console.WriteLine("Cap nhat thong tin sinh vien");
}