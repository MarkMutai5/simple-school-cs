using System.ComponentModel.DataAnnotations;

namespace SampleSchool.Models;

public class Class
{
    [Key]
    public int Id { get; set; }
    public string name { get; set; }
    public string classTeacher { get; set; }
    public Student Student { get; set; }
}