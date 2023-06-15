using Microsoft.EntityFrameworkCore;

namespace EfcoreCodeFirstCRUD.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
