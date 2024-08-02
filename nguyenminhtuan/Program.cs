using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        ID = id;
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách các đối tượng Student
        List<Student> students = new List<Student>
        {
            new Student(1, "Anh", 20),
            new Student(2, "Khuong", 17),
            new Student(3, "Khang", 18),
            new Student(4, "Chau", 21),
            new Student(5, "Nhat", 16)
        };

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("Danh sach toan bo hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
        var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("\nHoc sinh co tuoi tu 15 đen 18:");
        foreach (var student in studentsAge15To18)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        var studentsNameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
        Console.WriteLine("\nHoc sinh co ten bat đau bang chu 'A':");
        foreach (var student in studentsNameStartsWithA)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả các học sinh trong danh sách
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca cac hoc sinh: {totalAge}");

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).First();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: ID: {oldestStudent.ID}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
        var sortedByAge = students.OrderBy(s => s.Age);
        Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}