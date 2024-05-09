using System.ComponentModel.DataAnnotations;

namespace SampleSchool.ModelDTos;

public class StudentListDto
{
    [Required]
    public string firstName { get; set; }
    [Required]
    public string lastName { get; set; }
    [Required]
    public decimal feeBalance { get; set; }
    [Required]
    public string gender { get; set; }
    [Required]
    public string dorm { get; set; }
}