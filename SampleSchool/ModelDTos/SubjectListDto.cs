using System.ComponentModel.DataAnnotations;

namespace SampleSchool.ModelDTos;

public class SubjectListDto
{
    [Required]
    public string  name { get; set; }
    [Required]
    public string shortCode { get; set; }
}