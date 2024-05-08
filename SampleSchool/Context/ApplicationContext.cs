using Microsoft.EntityFrameworkCore;
using SampleSchool.Models;

namespace SampleSchool.Context;

public class ApplicationContext : DbContext
{
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Subject> Subjects { get; set; }
    public virtual DbSet<Parent> Parents { get; set; }
    public virtual DbSet<Class> Classes { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }
}