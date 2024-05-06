using System.ComponentModel.DataAnnotations;

namespace SampleSchool.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public decimal feeBalance { get; set; }
    public string gender { get; set; }
    public string dorm { get; set; }
    public Subject Subject { get; set; }
    public Book Book { get; set; }
    
}