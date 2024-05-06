using SampleSchool.Models;

namespace SampleSchool.Repositories;

public interface IStudentRepository
{
    Student GetSingle(int id);
    void Add(Student student);
    void Delete(int id);
    IQueryable<Student> GetAll();
}