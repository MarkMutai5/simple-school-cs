using System.ComponentModel.DataAnnotations;

namespace SampleSchool.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string name { get; set; }
    public string publisher { get; set; }
}