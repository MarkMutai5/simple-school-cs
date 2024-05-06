using System.ComponentModel.DataAnnotations;

namespace SampleSchool.Models;

public class Teacher
{
    [Key]
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int tscNumber { get; set; }
    public string role { get; set; }
}