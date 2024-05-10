using System.ComponentModel.DataAnnotations;

namespace SampleSchool.ModelDTos;

public class BookUpdateDto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string name { get; set; }
    [Required]
    public string publisher { get; set; }
}