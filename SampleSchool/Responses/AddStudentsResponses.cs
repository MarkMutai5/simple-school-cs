using System.Net;

namespace SampleSchool.Responses;

public class AddStudentsResponses
{
    public int Id { get; set; }
    public string responseDesc { get; set; }
}

public class StudentsResponse
{
    public AddStudentsResponses? message { get; set; }
    public string? result { get; set; }
    public HttpStatusCode statusCode { get; set; }
}