using Microsoft.EntityFrameworkCore;
using SampleSchool.Models;

namespace SampleSchool.Context;

public class ApplicationContext : DbContext
{
    public virtual DbSet<Student> Students { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }
}