using System.ComponentModel.DataAnnotations;

namespace SampleSchool.ModelDTos;

public class StudentUpdateDto
{
    [Required] public int Id { get; set; }
    [Required] public string firstName { get; set; }
    [Required] public string lastName { get; set; }
    [Required] public decimal feeBalance { get; set; }
    [Required] public string gender { get; set; }
    [Required] public string dorm { get; set; }
}