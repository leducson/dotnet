using System.ComponentModel.DataAnnotations;

namespace StudentManage.Models;

public class Student {

    public Student(string name) {
        Name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}