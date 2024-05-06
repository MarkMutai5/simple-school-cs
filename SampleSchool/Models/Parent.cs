using System.ComponentModel.DataAnnotations;

namespace SampleSchool.Models;

public class Parent
{
    [Key]
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public decimal phoneNumber { get; set; }
    public Student Student { get; set; }
}