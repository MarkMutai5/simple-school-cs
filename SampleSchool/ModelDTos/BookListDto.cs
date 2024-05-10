using System.ComponentModel.DataAnnotations;

namespace SampleSchool.ModelDTos;

public class BookListDto
{
    [Required]
    public string name { get; set; }
    [Required]
    public string publisher { get; set; }
}