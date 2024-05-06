using System.ComponentModel.DataAnnotations;

namespace SampleSchool.Models;

public class Subject
{
    [Key]
    public int Id { get; set; }
    public string  name { get; set; }
    public string shortCode { get; set; }
    public Student Student { get; set; }
}