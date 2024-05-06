using SampleSchool.Models;

namespace SampleSchool.Repositories;

public class StudentRepository:IStudentRepository
{
    public Student GetSingle(int id)
    {
        return null;
    }

    public void Add(Student student)
    {
        
    }

    public void Delete(int id)
    {
        
    }

    public IQueryable<Student> GetAll()
    {
        Console.WriteLine("Getting all students");
        return null;
    }
}